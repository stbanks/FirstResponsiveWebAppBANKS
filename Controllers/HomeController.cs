using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppBANKS.Models;

namespace FirstResponsiveWebAppBANKS.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FRN = "Error";
            ViewBag.FRAN = "0";
            ViewBag.FRAL = "0";
            return View();
        }
        [HttpPost]
        public IActionResult Index(FirstResponsiveModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FRN = model.GrabName();
                ViewBag.FRAN = model.CalculateAgeNow();
                ViewBag.FRAL = model.CalculateAgeLater();
            }
            else
            {
                ViewBag.FRN = "Error";
                ViewBag.FRAN = "0";
                ViewBag.FRAL = "0";
            }
            return View(model);
        }
    }
}
