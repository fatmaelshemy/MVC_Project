using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using ProjectMVC.Hubs;
using ProjectMVC.Models;
using ProjectMVC.Repository;

namespace ProjectMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<Context>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
                options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Context>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();
            builder.Services.AddControllersWithViews();



            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<Context>();

            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<ICategory, CategoryRepository>();
            builder.Services.AddScoped<IJob, JobRepository>();
 
            builder.Services.AddScoped<IApplyForJob, ApplyForJobRepository>();

            builder.Services.AddScoped<ICampany, CampanyRepository>(); // Example registration, adjust as needed
            builder.Services.AddScoped<Ifeedback, FeedbackRepository>();

            builder.Services.AddScoped<IContact, ContactRepository>();
            builder.Services.AddScoped<SearchAboutRepository, SearchAboutRepository>();

            builder.Services.AddSignalR();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();


            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseDirectoryBrowser(new DirectoryBrowserOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot", "img")),
                RequestPath = "/img"
            });

            app.MapHub<jobHub>("/jobHub");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.MapRazorPages();

            app.Run();
        }
    }
}
