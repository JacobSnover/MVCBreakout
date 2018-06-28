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
            List<Employee> temp = new List<Employee>();
            temp = ORM.Employees.Where(x => x.EmpID == data.EmpID).ToList();
            
            if (!ModelState.IsValid || temp.Count > 0)
            {
                ViewBag.VerifyAdd = "That Entry Exists Aleady.";
                return View("About");
            }
           
            ORM.Employees.Add(data);
            ORM.SaveChanges();
            ViewBag.VerifyAdd = data.FirstName;

            return View("About");
        }

        public ActionResult AddPos(Position data)
        {
            LearnerEntities ORM = new LearnerEntities();
            List<Position> temp = new List<Position>();
            temp = ORM.Positions.Where(x => x.PosName == data.PosName).ToList();

            if (!ModelState.IsValid || temp.Count > 0)
            {
                ViewBag.VerifyAdd = "That Entry Exists Aleady.";
                return View("About");
            }
            ORM.Positions.Add(data);
            ORM.SaveChanges();
            ViewBag.VerifyAdd = data.PosName;

            return View("About");
        }

        public ActionResult AddCour(Course data)
        {
            LearnerEntities ORM = new LearnerEntities();
            List<Course> temp = new List<Course>();
            temp = ORM.Courses.Where(x => x.CourName == data.CourName).ToList();

            if (!ModelState.IsValid || temp.Count > 0)
            {
                ViewBag.VerifyAdd = "That Entry Exists Aleady.";
                return View("About");
            }
            ORM.Courses.Add(data);
            ORM.SaveChanges();
            ViewBag.VerifyAdd = data.CourName;

            return View("About");
        }

        public ActionResult AddStudent(Student data)
        {
            LearnerEntities ORM = new LearnerEntities();
            List<Student> temp = new List<Student>();
            temp = ORM.Students.Where(x => x.StudentID == data.StudentID).ToList();

            if (!ModelState.IsValid || temp.Count > 0)
            {
                ViewBag.VerifyAdd = "That Entry Exists Aleady.";
                return View("About");
            }
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