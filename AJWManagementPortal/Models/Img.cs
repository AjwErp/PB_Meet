using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class Img
    {
        [Key]
        public int Imgid { get; set; }
        public int Imgidd { get; set; }

        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        public string Imgnamed { get; set; }

        public string Imgpathd { get; set; }

        public string Imgname { get; set; }

        public string Imgpath { get; set; }
    }
}
