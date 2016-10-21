using System;
using CPV;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CPV.Controllers
{
    public class HomeController : CPVController
    {
        public override IActionResult Index(string themeName, string lang)
        {

            ViewData["Title"] = "Home Page";
            ViewData["BrandName"] = "Carpool Vote";


            if (lang == CPV.CPVConstants.LANGUAGE_SPANISH) {
                ViewData["Title"] = "Página de inicio";
                ViewData["BrandName"] = "Compartir coche votar";
            }
            return base.Index(themeName,lang);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
