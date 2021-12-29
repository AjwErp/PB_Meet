using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{   
    //This Model refeer to Law Books (Admin Office) 
    public class LawBook
    {
        public int Id { get; set; }

        public string previousPageNumber { get; set; }

        public string previousEditNumber { get; set; }

        public string pageNumber { get; set; }

        public string editNumber { get; set; }

        public string lawDescription { get; set; }
        public string title { get; set; }
        public string department { get; set; }
        public string Date { get; set; }

    }
}
