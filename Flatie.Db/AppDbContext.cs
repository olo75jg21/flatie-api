using Flatie.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flatie.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Following> Followings { get; set; }
    }
}