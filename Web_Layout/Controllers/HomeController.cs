using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Web_Layout.DAL;
using Web_Layout.Models;

namespace Web_Layout.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

       
        public ActionResult Index(string Machude)
        {
            Sach_DAL ob = new Sach_DAL();
            
          /*if (Machude is null)
                return View(ob.Get_Sach());*/

            if (Machude != null)
            {
                return View(ob.Get_Sach_ByChude(Machude));
            }
            else
            {
                return View(ob.Get_Sach());
            }
            
        }
    }
}