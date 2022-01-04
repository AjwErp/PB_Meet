using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Grpc.Core;
using System.Web;

namespace AJWManagementPortal.Areas.Account.Controllers
{ [Area("Account")]
    public class ErrorReportsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ErrorReportsController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult AccountsErrorReportsList()
        {
            IEnumerable<aDailyCash> a = _db.aDailyCashes.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 5).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            IEnumerable<MeezanBankIEReport> a1 = _db.MeezanBankIEReports.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 5).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            IEnumerable<DailySuppliersCashTransactionReport> a2 = _db.dailySuppliers.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 5).ToList().GroupBy(elem => elem.ValueDate).Select(group => group.First());
            IEnumerable<MonthlyClosingReport> monthlyClosingReports = _db.MonthlyClosingReports.Where(i => i.DelProduction != 0 && Convert.ToInt32(i.Status) == 5).ToList();
            DailyMeezan meezan = new DailyMeezan();
            meezan.aDailyCashes = a;
            meezan.Bank = a1;
            meezan.dSuppliers = a2;
            meezan.monthlyClosingReport = monthlyClosingReports;
            return View(meezan);
        }

        public async Task<IActionResult> DeleteSheet(String remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<aDailyCash> data = new List<aDailyCash>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.aDailyCashes.Where(i => i.ValueDate.Equals(dateTime10)).ToList();

            foreach (aDailyCash technical in data)
            {
                technical.Status = "1";
                var current = _db.aDailyCashes.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AccountsErrorReportsList");
        }

        public async Task<IActionResult> DeleteMeezanSheet(String remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<MeezanBankIEReport> data = new List<MeezanBankIEReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MeezanBankIEReports.Where(i => i.ValueDate.Equals(dateTime10)).ToList();

            foreach (MeezanBankIEReport technical in data)
            {
                technical.Status = "1";
                var current = _db.aDailyCashes.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AccountsErrorReportsList");
        }



        public async Task<IActionResult> DeleteSupplierSheet(String remarks)
        {
            remarks = remarks.Replace("-", "/");
            //_db.TechnicalStaffWorkPlans.RemoveRange(_db.TechnicalStaffWorkPlans.ToList().Where(x => x.Remarks.Equals(remarks)));
            //_db.SaveChanges();
            //return View("AjwTechnicalStaffWorkPlanList", _db.TechnicalStaffWorkPlans.ToList());
            List<DailySuppliersCashTransactionReport> data = new List<DailySuppliersCashTransactionReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.dailySuppliers.Where(i => i.ValueDate.Equals(dateTime10)).ToList();

            foreach (DailySuppliersCashTransactionReport technical in data)
            {
                technical.Status = "1";
                var current = _db.dailySuppliers.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }

                _db.SaveChanges();
            }
            return RedirectToAction("AccountsErrorReportsList");
        }
        public IActionResult SendMonthlyClosingReportToDgmOffice(string remarks)
        {
            remarks = remarks.Replace("-", "/");
            List<MonthlyClosingReport> data = new List<MonthlyClosingReport>();
            DateTime dateTime10 = DateTime.Parse(remarks);
            data = _db.MonthlyClosingReports.Where(i => i.ValueDate.Equals(dateTime10) && i.DelProduction != 0).ToList();

            foreach (MonthlyClosingReport technical in data)
            {
                technical.Status = "1";
                var current = _db.MonthlyClosingReports.Find(technical.Id);
                if (current != null)
                {
                    _db.Entry(current).CurrentValues.SetValues(technical);
                }
                _db.SaveChanges();
            }
            return RedirectToAction("AccountsErrorReportsList");
        }


       
        public IActionResult ExporDataToFile(int? Month, int? Year)
        {
            var reportmodel = GetReportDetail(1,2022);
            if (reportmodel != null)
            {
                ExportToPdf(reportmodel);
            }
            return RedirectToAction("AccountsErrorReportsList");
        }
        private void ExportToPdf(DataTable monthlyreport)
        {

            if (monthlyreport.Rows.Count > 0)
            {
                int pdfRowIndex = 1;
                string filename = "MonthlyReportDetails-" + DateTime.Now.ToString("dd-MM-yyyy hh_mm_s_tt");
                string filepath = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot", "PdfFiles/pdf"+"monthlyreport" +".pdf");
                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 5f, 5f, 10f, 10f);
                FileStream fs = new FileStream(filepath, FileMode.Create);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                Font font1 = FontFactory.GetFont(FontFactory.COURIER_BOLD, 10);
                Font font2 = FontFactory.GetFont(FontFactory.COURIER, 8);

                float[] columnDefinitionSize = { 2F, 5F, 2F, 5F };
                PdfPTable table;
                PdfPCell cell;

                table = new PdfPTable(columnDefinitionSize)
                {
                    WidthPercentage = 100
                };

                cell = new PdfPCell
                {
                    BackgroundColor = new BaseColor(0xC0, 0xC0, 0xC0)
                };

                table.AddCell(new Phrase("SignAManager", font1));
                table.AddCell(new Phrase("AManagerRemarks", font1));
              
                table.HeaderRows = 1;

                foreach (DataRow data in monthlyreport.Rows)
                {
                    table.AddCell(new Phrase(data["SignAManager"].ToString(), font2));
                    table.AddCell(new Phrase(data["AManagerRemarks"].ToString(), font2));
                 

                    pdfRowIndex++;
                }

                document.Add(table);
                document.Close();
                document.CloseDocument();
                document.Dispose();
                writer.Close();
                writer.Dispose();
                fs.Close();
                fs.Dispose();

                FileStream sourceFile = new FileStream(filepath, FileMode.Open);
                float fileSize = 0;
                fileSize = sourceFile.Length;
                byte[] getContent = new byte[Convert.ToInt32(Math.Truncate(fileSize))];
                sourceFile.Read(getContent, 0, Convert.ToInt32(sourceFile.Length));
                sourceFile.Close();
                Response.Clear();
                Response.Headers.Clear();
                Response.ContentType = "application/pdf";
                Response.Headers.Add("Content-Length", getContent.Length.ToString());
                Response.Headers.Add("Content-Disposition", "attachment; filename=" + filename + ".pdf;");
                Response.Body.WriteAsync(getContent);
                Response.Body.Flush();
            }
        }
        private DataTable GetReportDetail(int Month,int Year)
        {
            var reportExist = _db.MonthlyClosingReports.Where(x => x.Month == Month && x.Year == Year).ToList();


            DataTable dtReport = new DataTable("MonthlyClosingReports");
            dtReport.Columns.AddRange(new DataColumn[2] { new DataColumn("SignAManager"),
                new DataColumn("AManagerRemarks")
            });

            foreach (var reportObj in reportExist)
            {
                dtReport.Rows.Add(reportObj.SignAManager, reportObj.AManagerRemarks);
            }

            return dtReport;
        }
    }
    
    }
