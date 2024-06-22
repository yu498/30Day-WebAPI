
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() { }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }
   
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
