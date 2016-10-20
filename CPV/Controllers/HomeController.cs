using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CPV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			// Brand:
			// {CarPoolVote}
			// {Souls2ThePolls}
			
			// Language:
			// {English}
			// {Spanish}
			return View();
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
