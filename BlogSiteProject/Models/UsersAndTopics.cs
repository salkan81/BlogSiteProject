namespace BlogSiteProject.Models
{
    public class UsersAndTopics
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
