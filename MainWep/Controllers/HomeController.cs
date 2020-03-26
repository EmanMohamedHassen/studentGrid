using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using MainWep.Domains.StudentDomain.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainWep.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _db;
        public HomeController(IStudentRepository repo)
        {
            _db = repo; 
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetStudents([DataSourceRequest] DataSourceRequest request)
        {
            //try
            //{
                var data = _db.GetStudents();
                return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
            //}
            //catch (Exception ex)
            //{

            //    return Json("Error", JsonRequestBehavior.AllowGet);
            //}
           
        }
    }
}