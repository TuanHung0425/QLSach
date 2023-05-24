using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Web_Layout.Models
{
    public class CartItem
    {
       
        public string Masach { get; set; }
        [DisplayName("Tên sách")]
        public string Tensach { get; set; }
        [DisplayName("Đơn Giá")]
        public float Giaban { get; set; }
        [DisplayName("Ảnh bìa")]
        public string Anhbia { get; set; }
        [DisplayName("Số lượng")]
        public int Soluong { get; set; }
        [DisplayName("Thành tiền")]
        public float Thanhtien
        {
            get
            {
                return Giaban * Soluong;
            }
        }

    }
}