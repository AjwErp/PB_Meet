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
    public class TemplateGenerator
    {
            
        public static string GetHTMLString()
        {
            var connectionstring = "Server=DESKTOP-L5NG9E6\\SQLEXPRESS;Database=AJWManagementPortal0001;Trusted_Connection=True;MultipleActiveResultSets=true"
;

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);


            ApplicationDbContext _db = new ApplicationDbContext(optionsBuilder.Options);

            var distinctList = _db.TechnicalStaffWorkPlans.Where(i => i.DelRepo != 0 && Convert.ToInt32(i.Status) >= 1).ToList().GroupBy(x => new { x.Title, x.Date, x.Remarks }).Distinct().Select(group => group.First());

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
 <div class='header' align='center'><h1>AGRO INDUSTRY</h1></div>
                                <div class='header' align='center'><h1>Technical Staff Work Plan</h1></div>
                                                              <div>Date : 29-08-2021</div>

<table align='center'>
                                    <tr>
                                        <th>Id</th>
                                        <th colspan='2'>Name</th>
                                        <th colspan='2'>Designation</th>
                                        <th colspan='4'>Work Description</th>
                                        <th>Job Card</th>
                                    </tr>");
            TechnicalStaffWorkPlan teswp = new TechnicalStaffWorkPlan();
            foreach (var emp in distinctList)
            {

                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td colspan='2'>{1}</td>
                                    <td colspan='2'>{2}</td>
                                    <td colspan='4'>{3}</td>
                                    <td>{4}</td>
                                  </tr>", emp.Id, emp.Name, emp.Designation, emp.Description, emp.JobCard);
                teswp.Date = emp.Date;
                teswp.Remarks = emp.Remarks;
                teswp.SignPManager = emp.SignPManager;
                teswp.PManagerRemarks = emp.PManagerRemarks;
                teswp.SignGM = emp.SignGM;
                teswp.GMRemarks = emp.GMRemarks;
                teswp.SignCeo = emp.SignCeo;
                teswp.CeoRemarks = emp.CeoRemarks;

            }
            sb.Append(@"
                                </table>
            ");
            sb.Append(@"<table align='center'>

                                    <tr>
                                        <th colspan='4'>Remarks</th>
                                        <th>Production Manager Sign</th>
                                        <th></th>
<br>
                                        <th>Production Manager Remarks</th>
                                        <th></th>

                                        <th>GM Sign</th>
                                        <th></th>
<br>
                                        <th>GM Remarks</th>
                                        <th></th>
<br>
                                        <th>CEO Sign</th>
                                        <th></th>

                                        <th>CEO Remarks</th>
                                        <th></th>

                                    </tr>
            ");
            sb.AppendFormat(@"<tr>
                                    <td colspan='4'>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                    <td>{4}</td>
                                  </tr>", teswp.Remarks, teswp.SignPManager, teswp.PManagerRemarks, teswp.SignGM, teswp.GMRemarks);
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
