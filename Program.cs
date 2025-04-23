using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;



namespace MVC_Projec2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //HAGER
            //builder.Services.AddDbContext<MVCProjectContext>(
            //    options => options.UseSqlServer(
            //        builder.Configuration.GetConnectionString("ConnectionStrings")
            //        )
            //    );

            //SHIMAA

            builder.Services.AddDbContext<MVCProjectContext>(
               options => options.UseSqlServer(builder.Configuration.GetConnectionString("CS"))
               ); ;



            builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()  
    .AddEntityFrameworkStores<MVCProjectContext>()
    .AddDefaultTokenProviders();
            // Asmaa custom services
            builder.Services.AddScoped<IAtelierRepository, AtelierRepository>();
            builder.Services.AddScoped<IBookingReposirtory, BookingRepository>();
            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    await RoleInitializer.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
           
       

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

           await app.RunAsync();
        }
    }
}
