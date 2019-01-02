using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;

namespace MyTree.Shared.Services
{
    public class NewsApiTopHeadlinesResult
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        public List<object> articles { get; set; } = new List<object>();

    }

    public class NewsService
    {
        private string apiKey = @"aa789746b4904675801a0e6175b7acf3";

        public NewsService(HttpClient http)
        {
            _http = http ?? throw new ArgumentNullException(nameof(HttpClient));
        }
        private HttpClient _http;


        public async Task<NewsApiTopHeadlinesResult> GetHeadlines()
        {
            string uri = $"https://newsapi.org/v2/top-headlines?country=us&apiKey={apiKey}";
            Console.WriteLine("getting");

            NewsApiTopHeadlinesResult result = await _http.GetJsonAsync<NewsApiTopHeadlinesResult>(uri);

            // var getTask = _http.GetStringAsync(uri);
            // Console.WriteLine("task started");

            // string result = await getTask;
            Console.WriteLine("got " + result);
            return result;
        }
    }
}