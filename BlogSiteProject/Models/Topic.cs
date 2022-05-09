﻿using System.Collections.Generic;

namespace BlogSiteProject.Models
{
    public class Topic:BaseEntity
    {
        public Topic()
        {
            UsersAndTopics = new HashSet<UsersAndTopics>();
            ArticlesAndTopics = new HashSet<ArticlesAndTopics>();
        }
        public string Name { get; set; }
        public int? TotalUse { get; set; }
        public ICollection<UsersAndTopics> UsersAndTopics { get; set; }
        public ICollection<ArticlesAndTopics> ArticlesAndTopics { get; set; }

    }
}
