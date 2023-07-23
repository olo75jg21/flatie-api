using Flatie.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flatie.Db
{
    public class AppDbContextSeeder
    {
        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAppRole>().HasData(
                new UserAppRole { Id = 1, Name = "Admin" },
                new UserAppRole { Id = 2, Name = "User" }
            );

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", Password = "adminpassword", UserAppRoleId = 1 },
                new User { Id = 2, Username = "user1", Password = "user1password", UserAppRoleId = 2 },
                new User { Id = 3, Username = "user2", Password = "user2password", UserAppRoleId = 2 }
            );

            // Seed HomeSpaces
            modelBuilder.Entity<HomeSpace>().HasData(
                new HomeSpace { Id = 1, Name = "Living Room" },
                new HomeSpace { Id = 2, Name = "Kitchen" },
                new HomeSpace { Id = 3, Name = "Bedroom" }
            );

            // Seed HomeSpaceMembers
            modelBuilder.Entity<HomeSpaceMember>().HasData(
                new HomeSpaceMember { Id = 1, Role = "Owner", JoinedAt = DateTime.UtcNow, HomeSpaceId = 1, UserId = 1 },
                new HomeSpaceMember { Id = 2, Role = "Member", JoinedAt = DateTime.UtcNow, HomeSpaceId = 1, UserId = 2 },
                new HomeSpaceMember { Id = 3, Role = "Member", JoinedAt = DateTime.UtcNow, HomeSpaceId = 2, UserId = 1 },
                new HomeSpaceMember { Id = 4, Role = "Member", JoinedAt = DateTime.UtcNow, HomeSpaceId = 3, UserId = 3 }
            );
        }
    }
}