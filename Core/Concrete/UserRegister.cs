using Core.Abstract;

namespace Core.Concrete
{
    public class UserRegister:BaseEntity
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User User { get; set; }
    }
}
