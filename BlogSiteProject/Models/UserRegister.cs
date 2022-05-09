namespace BlogSiteProject.Models
{
    public class UserRegister:BaseEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public User User { get; set; }
    }
}
