using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;

namespace MyTree.Shared.Services
{
    public class NewsApiTopHeadlinesResult
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<NewsApiArticle> Articles { get; set; } = new List<NewsApiArticle>();
    }

    public class NewsApiArticle
    {
        public string Title { get; set; }
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
            NewsApiTopHeadlinesResult result = await _http.GetJsonAsync<NewsApiTopHeadlinesResult>(uri);
            return result;
        }
    }
}