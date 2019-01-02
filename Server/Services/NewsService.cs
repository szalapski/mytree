using System;

namespace MyTree.Server.Services
{
    public class NewsService
    {
        public string GetHeadlines()
        {
            return $"these will be the headlines from {DateTime.Now}";
        }
    }
}