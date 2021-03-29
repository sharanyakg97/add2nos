using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arithmeticlibrary.SampleLibrary;
using System.Diagnostics;
using SimpleSumCalculator.Models;

namespace SimpleSumCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();

        }

        public ActionResult About()
        {
            Debug.WriteLine("hello");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        

        [HttpPost]
        public ActionResult Index(SumCalculator obj)
        {

            obj.result = obj.firstNum + obj.secondNum;
            return View(obj);
        }
    }
};