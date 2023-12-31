﻿using Newtonsoft.Json;
using CKCDotNetCore.ConsoleApp.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CKCDotNetCore.ConsoleApp.RestClientExamples
{

    public class RestClientExample
    {
        private RestClient _client = new RestClient();
        private string _blogUrl = "http://localhost:5042/api/Blog";

        public async Task Run()
        {
            // await Read();
            // await Edit(1);
            // await Create("Test Title", "Kyaw Kyaw", "Tesing content body");
            // await Delete(3);
            // await Update(4, "Testing Title edit", "Hla Hla edit", "Tesing content body");
            await Update(5, "Testing title uppdate");
        }


        private async Task Read()
        {
            RestRequest request = new RestRequest(_blogUrl, Method.Get);
            var response = await _client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content!;
                List<BlogDataModel> blogs = JsonConvert.DeserializeObject<List<BlogDataModel>>(result)!;
                foreach (var item in blogs)
                {
                    Console.WriteLine($"{item.Blog_Id} {item.Blog_Title} {item.Blog_Author} {item.Blog_Content}");
                }
            }
            else
            {
                Console.WriteLine(response.Content);
            }
        }

        private async Task Edit(int id)
        {
            RestRequest request = new RestRequest($"{_blogUrl}/{id}", Method.Get);
            var response = await _client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content!;
                BlogDataModel item = JsonConvert.DeserializeObject<BlogDataModel>(result)!;
                Console.WriteLine($"{item.Blog_Id} {item.Blog_Title} {item.Blog_Author} {item.Blog_Content}");
            }
            else
            {
                Console.WriteLine(response.Content);
            }
        }

        private async Task Create(string title, string author, string content)
        {
            RestRequest request = new RestRequest(_blogUrl, Method.Post);
            request.AddJsonBody(new BlogDataModel { Blog_Title = title, Blog_Author = author, Blog_Content = content });
            var response = await _client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        private async Task Delete(int id)
        {
            RestRequest request = new RestRequest($"{_blogUrl}/{id}", Method.Delete);
            var response = await _client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }


        // update -> PUT
        private async Task Update(int id, string title, string author, string content)
        {
            RestRequest request = new RestRequest($"{_blogUrl}/{id}", Method.Put);
            request.AddJsonBody(new BlogDataModel { Blog_Title = title, Blog_Author = author, Blog_Content = content });
            var response = await _client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        // update -> PATCH
        private async Task Update(int id, string title)
        {
            RestRequest request = new RestRequest($"{_blogUrl}/{id}", Method.Patch);
            request.AddJsonBody(new BlogDataModel { Blog_Title = title });
            var response = await _client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}