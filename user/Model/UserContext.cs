
using Microsoft.EntityFrameworkCore;

namespace user.Model
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
              : base(options)
        {
        }

        public DbSet<User> TodoItems { get; set; }
    }
}
