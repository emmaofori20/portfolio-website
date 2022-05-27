using Amoponsah.Models;
using Amoponsah.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Amoponsah.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MailService mailService;

        public HomeController(ILogger<HomeController> logger, MailService mailService)
        {
            _logger = logger;
            this.mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        } 
        
        [HttpPost]
        public IActionResult Index(MailViewModel model)
        {
            mailService.sendMail(model);
            return View();
        }

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
