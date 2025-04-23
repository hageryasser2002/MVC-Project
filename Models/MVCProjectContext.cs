using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace MVC_Projec2.Models
{
    public class MVCProjectContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IConfiguration _configuration;

        public MVCProjectContext(DbContextOptions<MVCProjectContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Atelier> Ateliers { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<MakeUp_Service> MakeUpServices { get; set; }
        public DbSet<Decor> Decors { get; set; }
        public DbSet<Session> Sessions { get; set; }
        //public object MakeUp_Services { get; internal set; }
        


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        string? connectionString = _configuration.GetConnectionString("ConnectionStrings");
        //        optionsBuilder.UseSqlServer(connectionString);
        //    }
        //}


        public MVCProjectContext(DbContextOptions<MVCProjectContext> option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" }
            );


            var adminUserId = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = adminUserId,
                    UserName = "admin@example.com",
                    NormalizedUserName = "ADMIN@EXAMPLE.COM",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@1234!"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "0123456789",
                    PhoneNumberConfirmed = true
                }
            );


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = adminUserId, RoleId = "1" }
            );


            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    Id = 1,
                    user_id = adminUserId,
                    MakeupId = 1,
                    Hall_Id = 2,
                    Session_Id = 2,
                    Decor_Id = 1,
                    Atelier_Id = 3,
                    Status = "Confirmed",
                    Created_at = DateTime.Now
                },
                new Booking
                {
                    Id = 2,
                    user_id = adminUserId,
                    MakeupId = 4,
                    Hall_Id = 1,
                    Session_Id = 1,
                    Decor_Id = 2,
                    Atelier_Id = 1,
                    Status = "Pending",
                    Created_at = DateTime.Today
                }

            );


            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    user_id = adminUserId,
                    Content = "Excellent service!",
                    Hall_Id = 2,
                    MakeupId = 1,
                    Session_Id = 2,
                    Decor_Id = 1,
                    Atelier_Id = 3,
                    Created_at = DateTime.Now
                }

            );


            modelBuilder.Entity<Atelier>().HasData(
                new Atelier { Id = 1, Name = "Elite Atelier", Location = "Downtown" },
                new Atelier { Id = 2, Name = "Royal Designs", Location = "Uptown" },
                new Atelier { Id = 3, Name = "Glamorous Styles", Location = "City Center" },
                new Atelier { Id = 4, Name = "Elegant Creations", Location = "Suburb" }
            );

            modelBuilder.Entity<Hall>().HasData(
                new Hall { Id = 1, Name = "Grand Hall", Capacity = 500 },
                new Hall { Id = 2, Name = "Crystal Ballroom", Capacity = 300 },
                new Hall { Id = 3, Name = "Sunset Venue", Capacity = 200 }
            );

            modelBuilder.Entity<MakeUp_Service>().HasData(
                new MakeUp_Service { Id = 1, Name = "Bridal Makeup", Price = 1500 },
                new MakeUp_Service { Id = 2, Name = "Party Glam", Price = 800 },
                new MakeUp_Service { Id = 3, Name = "Natural Look", Price = 500 },
                new MakeUp_Service { Id = 4, Name = "Evening Elegance", Price = 1000 }
            );

            modelBuilder.Entity<Decor>().HasData(
                new Decor { Id = 1, Style = "Classic", Price = 5000 },
                new Decor { Id = 2, Style = "Modern", Price = 7000 },
                new Decor { Id = 3, Style = "Rustic", Price = 4500 }
            );

            modelBuilder.Entity<Session>().HasData(
                new Session { Id = 1, Type = "Photography", Duration = 2 },
                new Session { Id = 2, Type = "Videography", Duration = 3 },
                new Session { Id = 3, Type = "Engagement Shoot", Duration = 4 },
                new Session { Id = 4, Type = "Pre-Wedding Shoot", Duration = 5 }
            );
        }
    }
}
