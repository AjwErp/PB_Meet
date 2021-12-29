using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.ViewModels
{
    public class StudentViewModel
    {
        public string Naem { get; set; }
        public IFormFile ProfileImage { get; set; }
    }
}
