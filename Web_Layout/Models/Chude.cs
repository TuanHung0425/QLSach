using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Web_Layout.Models
{
    public class Chude
    {
        [Key]
        public string Machude { get; set; }
        [Required]
        public string Tenchude { get; set; }
        
    }
}