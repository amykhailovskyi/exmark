using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Models;
using DAL.Repository;
using ExMark.Models;

namespace ExMark.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository student = new StudentRepository();
        UnivercityRepository Univercity = new UnivercityRepository();
        FacultyRepository faculty = new FacultyRepository();

        public ActionResult Index()
        {
            var stud = student.GetAll();

            return View(stud);
        }

        public ActionResult StudentProfile(int id)
        {
            var stud = new StudentViewModel();
            stud.Student = student.GetById(id);
            stud.Faculty = faculty.GetById(stud.Student.FacultyId);
            stud.Univercity = Univercity.GetById(stud.Faculty.UnivercityId);


            return PartialView("StudentProfile", stud);
        }
    }
}
