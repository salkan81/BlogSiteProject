using System.Collections.Generic;

namespace BlogSiteProject.Models
{
    public class User:BaseEntity
    {
        public User()
        {
            UsersAndTopics = new HashSet<UsersAndTopics>();
            Articles = new HashSet<Article>();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte[] Picture { get; set; }
        public string Description { get; set; }
        public int UserRegisterId { get; set; }
        public UserRegister UserRegister { get; set; }
        public ICollection<UsersAndTopics> UsersAndTopics { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
