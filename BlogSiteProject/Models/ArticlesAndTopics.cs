namespace BlogSiteProject.Models
{
    public class ArticlesAndTopics
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
