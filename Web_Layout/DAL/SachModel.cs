using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Layout.Models;

namespace Web_Layout.DAL
{
    public class SachModel
    {
        private List<CartItem> product;
        Sach_DAL ob = new Sach_DAL();
        public SachModel() { }
        public List<CartItem> FindAll() {
            return this.product;
        }
        public CartItem Findproduct(string Masach1)
        {
            var list= ob.Get_Sach_ByMasach(Masach1.Trim()).FirstOrDefault();
            this.product = new List<CartItem>()
            {
                new CartItem()
                {
                    Masach = list.Masach,
                    Tensach= list.Tensach,
                    Giaban= list.Giaban,
                    Anhbia= list.Anhbia,
                }
            };
            return this.product.FirstOrDefault();

        }
    }
}