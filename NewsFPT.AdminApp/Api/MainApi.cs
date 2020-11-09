using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NewsFPT.AdminApp.Api
{
    public class MainApi
    {
        public HttpClient httpClient =null;
        public MainApi()
        {
            httpClient = new HttpClient();
        }
        public async Task<string> GetWebContent(string url)
        {
            using (var httpClient = new HttpClient())
            {
                Debug.WriteLine($"Starting connect {url}");
                try
                {
                    // Thêm header vào HTTP Request
                    httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml+json");
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Phát sinh Exception nếu mã trạng thái trả về là lỗi
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        Debug.WriteLine($"Tải thành công - statusCode {(int)response.StatusCode} {response.ReasonPhrase}");
                        // Đọc thông tin header trả về
                        ShowHeaders(response.Headers);


                        Debug.WriteLine("Starting read data");

                        // Đọc nội dung content trả về
                        string htmltext = await response.Content.ReadAsStringAsync();
                        Debug.WriteLine($"Nhận được {htmltext.Length} ký tự");
                        Debug.WriteLine("");
                        return htmltext;
                    }
                    else
                    {
                        Debug.WriteLine($"Lỗi - statusCode {response.StatusCode} {response.ReasonPhrase}");
                        return null;
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return null;
                }
            }
        }
        public static void ShowHeaders(HttpHeaders headers)
        {
            Debug.WriteLine("Các Header:");
            foreach (var header in headers)
            {
                string value = string.Join(" ", header.Value);
                Debug.WriteLine($"{header.Key,20} : {value}");
            }
            Debug.WriteLine("");
        }




        // Post Json Data
        public async Task<string> SendAsyncJson(string url, string json,bool isDelete)
        {
            Console.WriteLine($"Starting connect {url}");
            try
            {
                HttpRequestMessage request = null;
                if (isDelete) {request = new HttpRequestMessage(HttpMethod.Delete, url); }
                else { request = new HttpRequestMessage(HttpMethod.Post, url); }

                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                request.Content = httpContent;
                var response = await httpClient.SendAsync(request);
                var rcontent = await response.Content.ReadAsStringAsync();
                return rcontent;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}
