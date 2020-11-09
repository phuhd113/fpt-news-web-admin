using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.ViewModel.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsFPT.AdminApp.Api;
using NewsFPT.AdminApp.Models;
using Newtonsoft.Json;

namespace NewsFPT.AdminApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MainApi api;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            api = new MainApi();
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserForLoginModel request)
        {
            var url = "http://localhost:54975/api/Users/LoginAdmin";
            var json = JsonConvert.SerializeObject(request);
            var result = api.SendAsyncJson(url, json, false);
            Debug.WriteLine(result);
            var error = "";
            if (result.Result == "")
            {
                return RedirectToAction("Index", "News");
            }
            else
            {
                error = "Username or password is incorrect !  ";
            }
            return RedirectToAction("Index", error);
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
