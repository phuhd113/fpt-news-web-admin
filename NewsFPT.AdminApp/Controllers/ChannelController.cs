using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.ViewModel.ChannelsModel;
using Microsoft.AspNetCore.Mvc;
using NewsFPT.AdminApp.Api;
using Newtonsoft.Json;

namespace NewsFPT.AdminApp.Controllers
{
    public class ChannelController : Controller
    {
        private readonly MainApi api;

        public ChannelController()
        {
            this.api = new MainApi();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var htmltask = api.GetWebContent("http://localhost:54975/api/Channels");
            htmltask.Wait(); // Chờ tải xong
            // Hoặc wait htmltask; nếu chuyển Main thành async

            var html = htmltask.Result;
            //Debug.WriteLine(html != null ? html.Substring(0, 255) : "Lỗi");
            var result = JsonConvert.DeserializeObject<IEnumerable<ChannelViewModel>>(html);
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ChannelCreateModel request)
        {
            var url = "http://localhost:54975/api/Channels";
            var json = JsonConvert.SerializeObject(request);
            var result = api.SendAsyncJson(url, json, false);
            Debug.WriteLine(result);
            return RedirectToAction("Index", "Channel");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var htmltask = api.GetWebContent("http://localhost:54975/api/Channels" + "/" + id);
            htmltask.Wait(); // Chờ tải xong
            // Hoặc wait htmltask; nếu chuyển Main thành async
            var html = htmltask.Result;
            //Debug.WriteLine(html != null ? html.Substring(0, 100) : "Lỗi");
            var result = JsonConvert.DeserializeObject<ChannelViewModel>(html);
            return View(result);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            var url = "http://localhost:54975/api/Channels";
            var json = JsonConvert.SerializeObject(id);
            var result = api.SendAsyncJson(url, json, true);
            Debug.WriteLine(result);
            return RedirectToAction("Index", "Channel");
        }

    }
}
