using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Algorithms()
        {
            ViewBag.Message = "Algorithms.";

            return View();
        }

        public ActionResult Jquery()
        {
            ViewBag.Message = "Fun with jQuery.";

            return View();
        }

        public ActionResult WeatherJs()
        {
            ViewBag.Message = "Get Weather (via (fontend) Web API).";

            return View();
        }

        public ActionResult WeatherClient()
        {
            ViewBag.Message = "Get Weather (via (backend) Web API).";

            return View();
        }

        public JsonResult GetWeather()
        {
            Weather weath = new Weather();
            return Json(weath.getWeatherForecast(), JsonRequestBehavior.AllowGet);
        }
    }
}