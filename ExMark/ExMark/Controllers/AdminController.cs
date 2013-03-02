using DAL.Repository;
using ExMark.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExMark.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult ProgressEdit(DateTime date)
        {
            var model = new ProgressEditViewModel();
            model.Students = new StudentRepository().GetAll();
            model.Schedule = new ScheduleRepository().GetByDate(date);

            return View(model);
        }
    }
}
