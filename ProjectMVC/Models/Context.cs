using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Models
{
	public class Context:IdentityDbContext<ApplicationUser>
	{
		public Context()
		{

		}
		public Context(DbContextOptions<Context> options) : base(options)
		{

		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Job> Jobs { get; set; }
		public DbSet<Company> Companys { get; set; }
		public DbSet<ApplyForJob> ApplyForJobs { get; set; }
		public DbSet<Feedback> Feedbacks { get; set; }

 		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.
		//   UseSqlServer("Data Source=NOUR;Initial Catalog=ProjectMVC;Integrated Security=True;Trust Server Certificate = False;Encrypt = False;");
		//}




	}
}
