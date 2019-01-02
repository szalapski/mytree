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

    }

    public class ContentItem
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public Source FeedSource { get; set; }
        public Source ContentSource { get; set; }
    }

    public class Source
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
