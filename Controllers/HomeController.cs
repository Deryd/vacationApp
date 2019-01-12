using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VacationApp.Models;
using VacationApp.Data;

namespace VacationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _appContext;

        public HomeController(ApplicationDbContext context)
        {
            _appContext = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View(_appContext.VacationRequests.ToList());
            }
            else
            {
                return Redirect("/Identity/Account/Login");
            }
        }

        // public IActionResult About()
        // {
        //     ViewData["Message"] = "Your application description page.";

        //     return View();
        // }

        // public IActionResult Contact()
        // {
        //     ViewData["Message"] = "Your contact page.";

        //     return View();
        // }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
