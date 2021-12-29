using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{ 
    //This Model Refer to Application User but into Identity Model--
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string MobileNumber { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }

        public string Gender { get; set; }
        public string Martialstatus { get; set; }

        public string Bloodgp { get; set; }
        public string Photo { get; set; }
        public string Photopath { get; set; }
        public string Address { get; set; }

        public byte[] Profile { get; set; }
    }
}
