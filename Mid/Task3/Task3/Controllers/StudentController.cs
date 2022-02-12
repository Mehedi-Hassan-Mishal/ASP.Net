using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task3.Models;

namespace Task3.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Submit(FormCollection form)
        {
            ViewBag.Name = form["Name"];
            ViewBag.Id = form["Id"];
            ViewBag.Dob = form["Dob"];
            ViewBag.Email = form["Email"];

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Submit", "Student");
            }
            return View(s);
        }

        /*
        public ActionResult Submit()
        {
            /* if (ModelState.IsValid)
            {
                return View(s);
            }
            return RedirectToAction("Create"); */
            /* 
             ViewBag.Name = Request["Name"];
             ViewBag.Id = Request["Id"];
             ViewBag.Dob = Request["Dob"];
             ViewBag.Email = Request["Email"];
            */

            /* (formCollection form)
            ViewBag.Name = form["Name"];
            ViewBag.Id = form["Id"];
            ViewBag.Dob = form["Dob"];
            ViewBag.Email = form["Email"];
            */

            /*public ActionResult Submit(string Name, string Id, string Dob, string Email)
            ViewBag.Name = Name;
            ViewBag.Id = Id;
            ViewBag.Dob = Dob;
            ViewBag.Email = Email;
            */


     
     }

}