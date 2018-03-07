using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using MVCBreakout.Models;


namespace MVCBreakout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LearnerEntities ORM = new LearnerEntities();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AddEmp(Employee data)
        {
            LearnerEntities ORM = new LearnerEntities();
            ORM.Employees.Add(data);
            ORM.SaveChanges();
            ViewBag.VerifyAdd = data.FirstName;
            
            return View("About");
        }

        public ActionResult AddPos(Position data)
        {
            LearnerEntities ORM = new LearnerEntities();
            ORM.Positions.Add(data);
            ORM.SaveChanges();
            ViewBag.VerifyAdd = data.Name;

            return View("About");
        }

        public ActionResult AddCour(Course data)
        {
            LearnerEntities ORM = new LearnerEntities();
            ORM.Courses.Add(data);
            ORM.SaveChanges();
            ViewBag.VerifyAdd = data.Name;

            return View("About");
        }

        public ActionResult AddStudent(Student data)
        {
            LearnerEntities ORM = new LearnerEntities();
            ORM.Students.Add(data);
            ORM.SaveChanges();
            ViewBag.VerifyAdd = data.FirstName;

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}