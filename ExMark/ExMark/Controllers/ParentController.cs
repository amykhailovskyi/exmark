using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Models;
using DAL.Repository;
using ExMark.ViewModel;

namespace ExMark.Controllers
{
    public class ParentController : Controller
    {
        StudentRepository studentRepository = new StudentRepository();
        ProgressRepository progressRepository = new ProgressRepository();

        public ActionResult Index(int id, DateTime? date)
        {
            if (date == null)
                date = DateTime.Now.Date;

            var progress = new ScheduleViewModel();
            progress.Student = studentRepository.GetById(id);
            progress.Progresses = progressRepository.Load(id, date);
            return PartialView("Index", progress);
        }

        public ActionResult List(List<Progress> progresses)
        {
            return PartialView("List", progresses);
        }
    }
}
