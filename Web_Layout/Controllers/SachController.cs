using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Layout.DAL;
using Web_Layout.Models;
namespace Web_Layout.Controllers
{
    public class SachController : Controller
    {
        // GET: Sach
        public ActionResult Index()
        {
            Sach_DAL ob = new Sach_DAL();
            var Sach_list = ob.Get_Sach();
            return View(Sach_list);
        }

        // GET: Sach/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sach/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sach/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sach/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sach/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sach/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sach/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
