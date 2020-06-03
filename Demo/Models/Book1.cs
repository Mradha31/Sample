using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Book1
    {
        [Key]
         [Required]
        public string Title { get; set; }

        public string Author { get; set; }
        public string ISBN { get; set; }

        public string Publisher { get; set; }

        public string Year { get; set; }
    }
}