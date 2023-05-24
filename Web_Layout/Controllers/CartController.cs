using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Layout.Models;
using Web_Layout.DAL;

namespace Web_Layout.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            List<CartItem> Cart = Session["Cart"] as List<CartItem>;
            return View(Cart);
        }
        public RedirectToRouteResult AddToCart(String Masach1)
        {
            if (Session["Cart"] == null)  // Nếu giỏ hàng chưa được cải tạo
            {
                Session["Cart"] = new List<CartItem>(); // khoi tai gio hang la 1 cartitem
            }
            List<CartItem> Cart = Session["Cart"] as List<CartItem>;// gan qua bien gio hang de code
            if (Cart.FirstOrDefault(m => m.Masach == Masach1) == null)
            {
                SachModel db = new SachModel();
                CartItem product = db.Findproduct(Masach1);
                CartItem newItem = new CartItem()
                {
                    Masach = product.Masach,
                    Tensach = product.Tensach,
                    Soluong = 1,
                    Anhbia = product.Anhbia,
                    Giaban = product.Giaban

                };// tao ra 1 cartitem moi
                Cart.Add(newItem);
            }
            else
            {
                CartItem cartItem= Cart.FirstOrDefault(m => m.Masach == Masach1);
                cartItem.Soluong++;

            }
            return RedirectToAction("Index", "Cart");
        }
        public ActionResult CapnhatGiohang(String Masach1,FormCollection f) {
            List<CartItem> Cart = Session["Cart"] as List<CartItem>;
            CartItem EditAmount = Cart.FirstOrDefault(m => m.Masach == Masach1);
            if (EditAmount != null)
            {
                EditAmount.Soluong= int.Parse(f["txtsoluong"].ToString());

            }
            return RedirectToAction("Index");

        }
        public RedirectToRouteResult RemoveItem(string Masach1)
        {
            List<CartItem> Cart = Session["Cart"] as List<CartItem>;
            CartItem DelItem = Cart.FirstOrDefault(m => m.Masach == Masach1);
            if (DelItem != null)
            {
                Cart.Remove(DelItem);
            }
            return RedirectToAction("Index");
            
        }
    }
}