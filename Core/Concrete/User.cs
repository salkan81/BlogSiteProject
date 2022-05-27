using Core.Abstract;
using System.Collections.Generic;

namespace Core.Concrete
{
    public class User:BaseEntity
    {
        public User()
        {
            UsersAndTopics = new HashSet<UsersAndTopics>();
            Articles = new HashSet<Article>();

        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
        public int UserRegisterId { get; set; }
        public UserRegister UserRegister { get; set; }
        public ICollection<UsersAndTopics> UsersAndTopics { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
