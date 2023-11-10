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
    public class AttractionsController : Controller
    {
        private Model1 model1 = new Model1();
        private List<Attractions> GetAttractionsData()
        {
            // 从数据库或其他数据源中获取数据并返回
            var attractionsList = new List<Attractions>();
            // 填充 attractionsList 
            return attractionsList;
        }

        //查
        public ActionResult Index(int? page, int? cityID, string sortOrder, string searchKeyword)
        {
            var attractions = model1.Attractions.ToList();

            // 创建一个字典来存储CityID和城市名称的映射关系
            var cityIdToNameMap = new Dictionary<int, string>
    {
        { 0, "All" },
        { 1, "Tianjing" },
        { 2, "Beijing" },
        { 3, "Shanghai" },
        { 4, "Guangzhou" },
        { 5, "Nanjing" },
    };
            // 根据cityID进行筛选
            if (cityID.HasValue && cityID.Value != 0)
            {
                attractions = attractions.Where(a => a.CityID == cityID.Value).ToList();
            }

            // 根据搜索关键字进行模糊搜索
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                attractions = attractions.Where(a => a.AttractionName.Contains(searchKeyword)).ToList();
            }

            // 根据sortOrder进行排序
            switch (sortOrder)
            {
                case "asc":
                    attractions = attractions.OrderBy(a => a.Price).ToList();
                    break;
                case "desc":
                    attractions = attractions.OrderByDescending(a => a.Price).ToList();
                    break;
                default:
                    // 默认按升序排序
                    attractions = attractions.OrderBy(a => a.Price).ToList();
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);

            ViewBag.CityIdToNameMap = cityIdToNameMap; // 传递CityID和城市名称的映射关系给View
            ViewBag.SortOrder = sortOrder; // 传递排序方式给View
            ViewBag.SearchKeyword = searchKeyword; // 传递搜索关键字给View

            return View(attractions.ToPagedList(pageNumber, pageSize));
        }


        //增
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Attractions attractions)
        {
            if (!ModelState.IsValid)
            {
                return Content("error");
            }
     
            model1.Attractions.Add(attractions);
            model1.SaveChanges();
            return Content("OK");
        }

        //修改
        Attractions attractions = new Attractions();
        public ActionResult Edit(int id)
        {
            attractions = model1.Set<Attractions>().Where(u => u.AttractionID == id).FirstOrDefault();
            return View(attractions);
        }
        [HttpPost]
        public ActionResult Edit(Attractions attractions)
        {
            if (!ModelState.IsValid)
            {
                return Content("error");
            }
            model1.Attractions.Attach(attractions);
            model1.Entry(attractions).State = EntityState.Modified;
            model1.SaveChanges();
            return Content("OK");
        }
        //删除
        public ActionResult Delete (int id)
        {
            attractions.AttractionID = id;
            model1.Attractions.Attach(attractions);
            model1.Entry(attractions).State = EntityState.Deleted;
            model1.SaveChanges();
            return Content("ok");
        }
       
          

    }

}