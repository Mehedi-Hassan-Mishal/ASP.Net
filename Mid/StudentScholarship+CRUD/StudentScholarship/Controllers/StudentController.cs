using StudentScholarship.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentScholarship.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            StudentEntities db = new StudentEntities();

            var data = db.Students1.ToList();

            return View(data);




        }
        [HttpGet]
        public ActionResult CreateStudent()
        {
            return View(new Students1());
        }

        [HttpPost]

        public ActionResult CreateStudent(Students1 s)
        {
            if (ModelState.IsValid)
            {

                StudentEntities db = new StudentEntities();
                db.Students1.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]

        public ActionResult SpecialScholarship()
        {
            StudentEntities db = new StudentEntities();
            var specialScholarship = (from b in db.Students1
                                      where b.DOB.Year <= DateTime.Now.Year - 30 && b.Cgpa >= 3.50
                                      select b).ToList();
            return View(specialScholarship);

  
        }

        [HttpGet]

        public ActionResult Scholarship()
        {
            StudentEntities db = new StudentEntities();
            var scholarship = (from b in db.Students1
                               where b.Cgpa >= 3.75
                               select b).ToList();
            return View(scholarship);

        }


        [HttpGet]
        public ActionResult EditStudent(int id)
        {
            StudentEntities db = new StudentEntities();
            var student = (from b in db.Students1
                           where b.Id == id
                           select b).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public ActionResult EditStudent(Students1 s)
        {
            StudentEntities db = new StudentEntities();
            var dat2 = (from ss in db.Students1
                        where ss.Id == s.Id
                        select ss).FirstOrDefault();

            db.Entry(dat2).CurrentValues.SetValues(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            StudentEntities db = new StudentEntities();
            var student = (from b in db.Students1
                           where b.Id == id
                           select b).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public ActionResult Delete(Students1 s)
        {
            StudentEntities db = new StudentEntities();
            var dat2 = (from ss in db.Students1
                        where ss.Id == s.Id
                        select ss).FirstOrDefault();

            db.Students1.Remove(dat2);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
