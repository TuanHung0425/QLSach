using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Web_Layout.Models
{
    public class Sach
    {
        [Key]
        public string Masach { get; set; }
        [Required]
        public string Tensach { get; set; }
        [Required]
        public float Giaban { get; set; }
        [Required]
        public string Mota { get; set; }
        [Required]
        public string Anhbia { get; set; }
        [Required]
        public DateTime Ngaycapnhat { get; set; }
        [Required]
        public int Soluongton { get; set; }
        [Required]
        public string Machude { get; set; }
        [Required]
        public string Manxb { get; set; }
    }
}