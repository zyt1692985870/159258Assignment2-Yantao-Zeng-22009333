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
    public class DestinationsController : Controller
    {
  
        private Model1 model1 = new Model1();
        // GET: Destinations
        public ActionResult Destinations(int? page)
        {
            var attractions = model1.Attractions.ToList();

            int pageSize = 5; // 每页显示的数量
            int pageNumber = (page ?? 1);

            return View(attractions.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Details(int id)
        {

            var attraction = model1.Attractions.Find(id);

            if (attraction == null)
            {
                return HttpNotFound(); 
            }

            return View(attraction);
        }


    }
}