using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BLL.ViewModel.NewsModels;
using Microsoft.AspNetCore.Mvc;
using NewsFPT.AdminApp.Api;
using NewsFPT.AdminApp.Models;
using Newtonsoft.Json;

namespace NewsFPT.AdminApp.Controllers
{
    public class NewsController : Controller
    {
        private readonly MainApi api;

        public NewsController()
        {
            this.api = new MainApi();
        }

        public IActionResult Index()
        {
            var htmltask = api.GetWebContent("http://localhost:54975/api/News");
            htmltask.Wait(); // Chờ tải xong
            // Hoặc wait htmltask; nếu chuyển Main thành async

            var html = htmltask.Result;
            Debug.WriteLine(html != null ? html.Substring(0, 255) : "Lỗi");
            var data = GetListNews(html);
            return View(data);
        }
        [HttpPost]
        public IActionResult Create(CreateNewsRequest request)
        {
            var url = "http://localhost:54975/api/News";
            var json = JsonConvert.SerializeObject(request);
            var result = api.SendAsyncJson(url, json,false);
            Debug.WriteLine(result);
            return View("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var url = "http://localhost:54975/api/News" + "/" + id;
            var json = JsonConvert.SerializeObject(id);
            var result = api.SendAsyncJson(url, json,true);
            Debug.WriteLine(result);
            return RedirectToAction("Index");
        }

        [HttpGet("News/Details/{id}")]
        public IActionResult Details(int id)
        {
            var htmltask = api.GetWebContent("http://localhost:54975/api/News"+"/"+id);
            htmltask.Wait(); // Chờ tải xong
            // Hoặc wait htmltask; nếu chuyển Main thành async
            var html = htmltask.Result;
            Debug.WriteLine(html != null ? html.Substring(0, 100) : "Lỗi");
            var data = GetNews(html);
            return View(data);
        }

        public static IEnumerable<NewsViewModel> GetListNews(String json)
        {
            var result = JsonConvert.DeserializeObject<IEnumerable<NewsViewModel>>(json);
            Debug.WriteLine("Test : " +result.FirstOrDefault().NewsTitle);
            return result;
        }
        public static NewsViewModel GetNews(String json)
        {
            var result = JsonConvert.DeserializeObject<NewsViewModel>(json);
            return result;
        }
    }
}
