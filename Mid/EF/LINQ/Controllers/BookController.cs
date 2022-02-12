using LINQ.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LINQ.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            //db retrival
            MidTask4Entities db = new MidTask4Entities();
            var data = db.Books.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Book());
        }
        [HttpPost]
        public ActionResult Create (Book b)
        {
            if(ModelState.IsValid)
            {
                //db insertion
                MidTask4Entities db = new MidTask4Entities();
                db.Books.Add(b);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}