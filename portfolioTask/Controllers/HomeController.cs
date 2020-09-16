using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using portfolioTask.Models;
using portfolioTask.Services;

namespace portfolioTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonRepository _person;

        //IPersonRepository and ILogger are injected through the HomeController constructor
        public HomeController(ILogger<HomeController> logger, IPersonRepository person)
        {
            _logger = logger;
            _person = person;
        }

        //Index Action method
        public IActionResult Index(int id = 1)
        {
            var model = _person.GetPerson(id);
            if (model != null)
            {
                return View(model);
            }
            else
            {
                return View("Error"); 
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
