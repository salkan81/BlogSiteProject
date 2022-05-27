using Core.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRegister> UserRegisters { get; set; }
        public DbSet<ArticlesAndTopics> ArticlesAndTopics { get; set; }
        public DbSet<UsersAndTopics> UsersAndTopics { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticlesAndTopics>().HasKey(at => new
            {
                at.ArticleId,
                at.TopicId
            });
            modelBuilder.Entity<UsersAndTopics>().HasKey(ut => new
            {
                ut.UserId,
                ut.TopicId
            });
        }
    }

   
}
