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

            modelBuilder.Entity<User>().HasData(
                            new User { Id = 1, Username = "admin", Password = "adminpassword", UserAppRoleId = 1 },
                            new User { Id = 2, Username = "user1", Password = "user1password", UserAppRoleId = 2 },
                            new User { Id = 3, Username = "user2", Password = "user2password", UserAppRoleId = 2 }
                        );

            modelBuilder.Entity<HomeSpace>().HasData(
                            new HomeSpace { Id = 1, Name = "Living Room" },
                            new HomeSpace { Id = 2, Name = "Kitchen" },
                            new HomeSpace { Id = 3, Name = "Bedroom" }
                        );

            modelBuilder.Entity<Notification>().HasData(
                           new Notification { Id = 1, Message = "Notification 1", Read = false, UserId = 1, HomeSpaceId = 1, NotificationTypeId = 1 },
                           new Notification { Id = 2, Message = "Notification 2", Read = true, UserId = 2, HomeSpaceId = 1, NotificationTypeId = 2 }
                       );

            modelBuilder.Entity<ShoppingList>().HasData(
                            new ShoppingList { Id = 1, ItemName = "Milk", Amount = 2, PurchasePrice = 5, CategoryId = 1, HomeSpaceId = 1, RequestedByUserId = 2, PucharsedByUserId = 1 },
                            new ShoppingList { Id = 2, ItemName = "Bread", Amount = 3, PurchasePrice = 3, CategoryId = 2, HomeSpaceId = 1, RequestedByUserId = 1, PucharsedByUserId = 2 }
                        );

            modelBuilder.Entity<ShoppingListCategory>().HasData(
                           new ShoppingListCategory { Id = 1, Name = "Dairy" },
                           new ShoppingListCategory { Id = 2, Name = "Bakery" }
                       );

            modelBuilder.Entity<QuietHour>().HasData(
                            new QuietHour { Id = 1, Reason = "Study time", Start = DateTime.UtcNow, End = DateTime.UtcNow.AddHours(2), UserId = 1, HomeSpaceId = 1, QuietHourImportanceId = 1 },
                            new QuietHour { Id = 2, Reason = "Quiet reading", Start = DateTime.UtcNow.AddDays(2), End = DateTime.UtcNow.AddDays(2).AddHours(2), UserId = 2, HomeSpaceId = 1, QuietHourImportanceId = 2 }
                        );

            modelBuilder.Entity<QuietHourImportance>().HasData(
                           new QuietHourImportance { Id = 1, Rank = 1 },
                           new QuietHourImportance { Id = 2, Rank = 2 }
                       );

            modelBuilder.Entity<UserTask>().HasData(
                           new UserTask { Id = 1, Title = "Complete assignment", Description = "Finish the project by next week", Completed = false, DueDate = DateTime.UtcNow.AddDays(7), RewardPoints = 100, UserId = 1, HomeSpaceId = 1 },
                           new UserTask { Id = 2, Title = "Buy groceries", Description = "Get milk, eggs, and bread", Completed = true, DueDate = DateTime.UtcNow.AddDays(2), RewardPoints = 50, UserId = 2, HomeSpaceId = 1 }
                       );

            modelBuilder.Entity<HomeSpaceMember>().HasData(
                            new HomeSpaceMember { Id = 1, Role = "Owner", JoinedAt = DateTime.UtcNow, HomeSpaceId = 1, UserId = 1 },
                            new HomeSpaceMember { Id = 2, Role = "Member", JoinedAt = DateTime.UtcNow, HomeSpaceId = 1, UserId = 2 },
                            new HomeSpaceMember { Id = 3, Role = "Member", JoinedAt = DateTime.UtcNow, HomeSpaceId = 2, UserId = 1 },
                            new HomeSpaceMember { Id = 4, Role = "Member", JoinedAt = DateTime.UtcNow, HomeSpaceId = 3, UserId = 3 }
                        );

            modelBuilder.Entity<HomeSpacePreference>().HasData(
                           new HomeSpacePreference { Id = 1, Title = "Preference 1", Description = "Preference 1 description", UserId = 1, HomeSpaceId = 1 },
                           new HomeSpacePreference { Id = 2, Title = "Preference 2", Description = "Preference 2 description", UserId = 2, HomeSpaceId = 1 }
                       );

            modelBuilder.Entity<Guest>().HasData(
                          new Guest { Id = 1, HomeSpaceId = 1, InvitedByUserId = 1, Name = "Guest 1", Start = DateTime.UtcNow.AddDays(1), End = DateTime.UtcNow.AddDays(3) },
                          new Guest { Id = 2, HomeSpaceId = 1, InvitedByUserId = 2, Name = "Guest 2", Start = DateTime.UtcNow.AddDays(2), End = DateTime.UtcNow.AddDays(4) }
                      );

            modelBuilder.Entity<NotificationType>().HasData(
                          new NotificationType { Id = 1, TypeName = "Important" },
                          new NotificationType { Id = 2, TypeName = "Regular" }
                      );
        }
    }
}