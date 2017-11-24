using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using app.Services;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        private static AppSettings _appSettings { get; set; }
        private static ILogService _logService { get; set; }

        public HomeController(IOptions<AppSettings> appSettings, ILogService logService)
        {
            _appSettings = appSettings.Value;
            _logService = logService;
        }
        public IActionResult Index()
        {
            ViewData["SiteName"] = _appSettings.SiteName;
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = _logService.Write("Log will be here!");
            ViewData["Random"] = new Random().Next(1000);
            var cookieBuilder = new System.Text.StringBuilder("<ul>");
            foreach (var item in HttpContext?.Request?.Cookies)
            {
                cookieBuilder.Append($"<li>{item.Key}={item.Value}</li>");

            }
            cookieBuilder.Append("</ul>");
            ViewData["Cookies"] = cookieBuilder.ToString();
            return View();
        }

        public IActionResult About()
        {
            var member_1 = new Member
            {
                EMail = "selcukusta@gmail.com",
                UserName = "selcukusta",
                ProfileImageUrl = "http://i0.kym-cdn.com/entries/icons/original/000/000/091/TrollFace.jpg"
            };

            var member_2 = new Member
            {
                UserName = "no_name",
                ProfileImageUrl = "http://i0.kym-cdn.com/entries/icons/original/000/000/091/TrollFace.jpg"
            };

            return View(new List<Member> { member_1, member_2 });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
