using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Trafic_Signal_Management.Models;
using Trafic_Signal_Management.Services;
using Microsoft.AspNetCore.Http;

namespace Trafic_Signal_Management.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        ValidationService validate = new ValidationService();
        TrafficManager _manager = new TrafficManager();
        public ActionResult Index(GlobalConfig config)
        {
            var username = validate.Validate_Token(Request.Cookies["Jwtoken"]);
            if (!string.IsNullOrEmpty(username))
            {

                return View();
            }
            return RedirectToAction("Login");
           // return View();
        }
        [HttpGet]
        public ActionResult GlobalConfig()
        {
            var username = validate.Validate_Token(Request.Cookies["Jwtoken"]);
            if (!string.IsNullOrEmpty(username))
            {
                return View();
            }
            return RedirectToAction("Login");
        }
        [HttpPost]
        public ActionResult GlobalConfig(GlobalConfig config)
        {
            var username = validate.Validate_Token(Request.Cookies["Jwtoken"]);

            if (!string.IsNullOrEmpty(username))
            {
                //save configuration
                _manager.SaveConfig(username, config);
                return RedirectToAction("Index", new { config = config });
            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login user)
        {
            if (validate.Authenticate_User(user))
            {
                Response.Cookies.Append(
                "Jwtoken",
                validate.Generate_Token(user.UserName),
                new Microsoft.AspNetCore.Http.CookieOptions()
                {
                    Path = "/"
                }
                );

                return RedirectToAction("GlobalConfig");
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
