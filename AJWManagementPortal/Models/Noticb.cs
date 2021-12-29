using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class Noticb
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string SDImgname { get; set; }

        public string SDImgpath { get; set; }

        public string SignImg { get; set; }

        public string SignImgpath { get; set; }
    }
}
