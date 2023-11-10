using assignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PagedList;
using System.Web.Mvc;

namespace assignment.Controllers
{
    public class HomeController : Controller
    {
        private Model1 model1 = new Model1();
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult home()
        {
            return View();
        }
     
        

    }

}
