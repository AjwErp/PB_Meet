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
    public class AdminLawBookTemplateGenerator
    {
        public static string GetHTMLString(string id, string title, string date)
        {
            var connectionstring = "Server=DESKTOP-UQ4ORVG\\SQLEXPRESS;Database=AJWManagementPortal;Trusted_Connection=True;MultipleActiveResultSets=true"
;

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);


            ApplicationDbContext _db = new ApplicationDbContext(optionsBuilder.Options);

            var distinctList = _db.LawBooks.Where(i => i.title.Equals(title) && i.Date.Equals(date) && i.department.Equals(id)).ToList();

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>This is the generated PDF report!!!</h1></div>
                                <table align='center'>
                                    <tr>

                                        <th>Id</th>
                                        <th>lawDescription</th>
                                        <th>previousPageNumber</th>
                                        <th>previousEditNumber</th>
                                        <th>pageNumber</th>
                                        <th>editNumber</th>
                                        <th>department</th>
                                    </tr>");
            LawBook teswp = new LawBook();
            foreach (var emp in distinctList)
            {

                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                    <td>{4}</td>
                                    <td>{5}</td>
                                    <td>{6}</td>
                                  </tr>", emp.Id, emp.department,emp.lawDescription, emp.pageNumber, emp.previousPageNumber, emp.editNumber, emp.previousEditNumber);
                //teswp.Id = emp.Id;
                //teswp.Date = emp.Date;
                //teswp.department = emp.department;
                //teswp.title = emp.title;
                //teswp.lawDescription = emp.lawDescription;
                //teswp.editNumber = emp.editNumber;
                //teswp.pageNumber = emp.pageNumber;
                //teswp.previousEditNumber = emp.previousEditNumber;
                //teswp.previousPageNumber = emp.previousPageNumber;

            }
            sb.Append(@"
                                </table>
            ");
//            sb.Append(@"<table align='center'>
//                                    <tr>
//                                        <th>Remarks</th>
//                                        <th>SignPManafger</th>
////                                        <th>PManagerRemarks</th>
////                                        <th>SignGM</th>
////                                        <th>GMRemarks</th>
////                                    </tr>
////            ");
//            sb.AppendFormat(@"<tr>
//                                    <td>{0}</td>
//                                    <td>{1}</td>
//                                    <td>{2}</td>
//                                    <td>{3}</td>
//                                    <td>{4}</td>
//                                  </tr>", teswp.Date, teswp.department, teswp.title, teswp.lawDescription, teswp.editNumber, teswp.pageNumber, teswp.previousEditNumber, teswp.previousPageNumber);
//            sb.Append(@"
//                                </table>
//            ");
            sb.Append(@"
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
