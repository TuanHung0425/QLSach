using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Web_Layout.DAL;
using Web_Layout.Models;


namespace Web_Layout.Controllers
{
    public class ChudeController : Controller
    {
        // GET: Chude
        Chude_DAL ob = new Chude_DAL();
        public ActionResult Index()
        {
            var Chude_list = ob.Get_Chude();
            return View(Chude_list);
        }

        // GET: Chude/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Chude/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chude/Create
        [HttpPost]
        public ActionResult Create(Chude ob1)
        {
            if (ModelState.IsValid)
            {
                ob.Insert_Chude(ob1);
            }
            return RedirectToAction("Index");
        }

        // GET: Chude/Edit/5
        public ActionResult Edit(string id)
        {
    var Chudes = ob.Get_Chude_Byma(id).FirstOrDefault();
    return View(Chudes);
        }
        // POST: Chude/Edit/5
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(Chude ob1 )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ob.Update_Chude(ob1);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chude/Delete/5
        public ActionResult Delete(string id)
        {
            var Chude1 = ob.Get_Chude_Byma(id).FirstOrDefault();

            return View(Chude1);
        }

        // POST: Chude/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete_Chude(string id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ob.Delete_Chude(id);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
