using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewsFPT.AdminApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {     
            return View();
        }          
    }
}
