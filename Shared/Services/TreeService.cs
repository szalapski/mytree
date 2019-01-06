using System.Collections.Generic;
using System.Linq;

namespace MyTree.Shared.Services
{
    public class Tree
    {
        public List<ContentItem> Items { get; set; } = new List<ContentItem>();
        public List<Tree> Trees { get; set; } = new List<Tree>();
        public bool IsEmpty => Items.Count == 0;
        public bool IsLeaf => Items.Count == 1;
        public bool IsNode => Items.Count > 1;
        public bool IsTwig => IsNode && Trees.Count <= 1;
        public ContentItem Leaf => IsLeaf ? Items.Single() : null;
        public List<KeyValuePair<string, int>> SourceCounts { get; set; } =
            new List<KeyValuePair<string, int>>();

        public static Tree From(NewsApiTopHeadlinesResult headlines)
        {
            var items = headlines.Articles
                    .Select((NewsApiArticle x) => ContentItem.From(x))
                    .ToList();
            var result = new Tree()
            {
                Items = items
            };

            result.SourceCounts = items
                .GroupBy(
                    x => x.ContentSource.Name,
                    (key, g) => new KeyValuePair<string, int>(key, g.Count())
                )
                .OrderByDescending(kvp => kvp.Value)
                .ToList();

            return result;
        }


    }

    public class ContentItem
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public Source FeedSource { get; set; }
        public Source ContentSource { get; set; }

        public static ContentItem From(NewsApiArticle article)
        {
            return new ContentItem()
            {
                Title = article.Title,
                Url = article.Url,
                Content = article.Content,
                ContentSource = new Source { Id = article.ContentSource.Id, Name = article.ContentSource.Name },
                FeedSource = new Source { Name = "newsapi.org" }
            };
        }
    }


    public class Source
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
