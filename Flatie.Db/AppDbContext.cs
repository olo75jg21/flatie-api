using Flatie.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flatie.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Guest> Guests { get; set; } = null!;
        public DbSet<HomeSpace> HomeSpaces { get; set; } = null!;
        public DbSet<HomeSpaceMember> HomeSpaceMembers { get; set; } = null!;
        public DbSet<HomeSpacePreference> HomeSpacePreferences { get; set; } = null!;
        public DbSet<Invitation> Invitations { get; set; } = null!;
        public DbSet<Notification> Notifications { get; set; } = null!;
        public DbSet<QuietHour> QuietHours { get; set; } = null!;
        public DbSet<ShoppingList> ShoppingLists { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<UserTask> UserTasks { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.HomeSpaces)
                .WithMany(e => e.Users)
                .UsingEntity<HomeSpaceMember>();

            modelBuilder.Entity<ShoppingList>()
                  .HasOne(s => s.PuchasedByUser)
                  .WithMany(u => u.ShoppingLists)
                  .HasForeignKey(s => s.PucharsedByUserId)
                  .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Invitation>()
                .HasOne(inv => inv.RecipientUser)
                .WithMany(user => user.Invitations)
                .HasForeignKey(inv => inv.RecipientUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HomeSpaceMember>(entity =>
            {
                entity.Property(e => e.HomeSpaceMemberRoleId)
                    .HasDefaultValue(1);
            });

            AppDbContextSeeder seeder = new AppDbContextSeeder();
            seeder.SeedData(modelBuilder);
        }
    }
}