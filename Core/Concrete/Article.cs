using Core.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Concrete
{
    public class Article:BaseEntity
    {
        public Article()
        {
            ArticlesAndTopics = new HashSet<ArticlesAndTopics>();
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int AvgReadTime { get; set; }
        public int? TotalReadCount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<ArticlesAndTopics> ArticlesAndTopics { get; set; }
    }
}
