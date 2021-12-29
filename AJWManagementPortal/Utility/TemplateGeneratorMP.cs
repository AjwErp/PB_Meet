using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJWManagementPortal.Utility
{
    public class TemplateGeneratorMP
    {
        public static string GetHTMLString()
        {
            var connectionstring = "Server=DESKTOP-UQ4ORVG\\SQLEXPRESS;Database=AJWManagementPortal;Trusted_Connection=True;MultipleActiveResultSets=true"
;

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);


            ApplicationDbContext _db = new ApplicationDbContext(optionsBuilder.Options);

            var distinctList = _db.ManagementStaffWorkPlans.Where(i => i.DelRepoMP != 0 && Convert.ToInt32(i.MPStatus) >= 1).ToList().GroupBy(x => new { x.MPTitle, x.MPDate }).Distinct().Select(group => group.First());
            //<div align='center'><img src='~/Image/ajwA.png' /><div>
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                               
                                <div class='header' align='center'><h1>AGRO INDUSTRY</h1></div>
                                <div class='header' align='center'><h1>Management Staff Work Plan</h1></div>
                                <div>Date : 29-08-2021</div>

                                <table align='center' border='8px'>
                                    <tr align='center'>
                                        <th> Id </th>
                                        <th colspan='2'> Name </th>
                                        <th colspan='2'> Designation </th>
                                        <th> Time In </th>
                                        <th> Time Out </th>
                                        <th colspan='4'> Work Description </th>
                                        <th colspan='2'> Sign Officer </th>
                                    </tr>");
            ManagementStaffWorkPlan teswp = new ManagementStaffWorkPlan();
            foreach (var emp in distinctList)
            {

                sb.AppendFormat(@"<tr align='center'>
                                    <td>{0}</td>
                                    <td colspan='2'>{1}</td>
                                    <td colspan='2'>{2}</td>
                                    <td>{3}</td>
                                    <td>{4}</td>
                                    <td colspan='4'>{5}</td>
                                    <td colspan='2'>{6}</td>
                                  </tr>", emp.Id, emp.MPName, emp.MPDesignation,emp.Timein,emp.Timeout, emp.MPDescription,emp.Signofficer);
                teswp.MPDate = emp.MPDate;
                //teswp.Remarks = emp.Remarks;
                teswp.SignPManagerMP = emp.SignPManagerMP;
                teswp.PManagerRemarksMP = emp.PManagerRemarksMP;
                teswp.SignGMMP = emp.SignGMMP;
                teswp.GMRemarksMP = emp.GMRemarksMP;
                teswp.SignCeoMP = emp.SignCeoMP;
                teswp.CeoRemarksMP = emp.CeoRemarksMP;

            }
            sb.Append(@"
                                </table>
            ");
             
            sb.Append(@"<table align='center' border='2px'>

                                    <tr align='center'>
                                        <th>Production Manager Sign</th>
                                        <th>Production Manager Remarks</th>
                                        <th>GM Sign</th>
                                        <th>GM Remarks</th>
                                        <th>CEO Sign</th>
                                        <th>CEO Remarks</th>
                                    </tr>
            ");
            sb.AppendFormat(@"<tr align='center'>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                    <td>{4}</td>
                                    <td>{5}</td>
                                  </tr>", teswp.SignPManagerMP, teswp.PManagerRemarksMP, teswp.SignGMMP, teswp.GMRemarksMP,teswp.SignCeoMP,teswp.CeoRemarksMP);
            sb.Append(@"
                                </table>
            ");
            sb.Append(@"
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
