using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using DAL.Models;

namespace ExMark.Models
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public Univercity Univercity { get; set; }
        public Faculty Faculty { get; set; }
    }
}