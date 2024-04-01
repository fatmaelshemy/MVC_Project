using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Models
{
    public class Context : IdentityDbContext<ApplicationUser>
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Insert Category data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Software Development", Description = "Software development related jobs" },
                new Category { Id = 2, Name = "UI/UX Design", Description = "UI/UX design related jobs" },
                new Category { Id = 3, Name = "Software Testing", Description = "Software Testing  related jobs" },
                new Category { Id = 4, Name = "Data Science", Description = "Data Science related jobs" },
                new Category { Id = 5, Name = "Digital Marketing", Description = "Digital Marketing related jobs" },
                new Category { Id = 6, Name = "Graphic Design", Description = "Graphic Design related jobs" },
                new Category { Id = 7, Name = "Financial Services", Description = "Financial Services related jobs" },
                new Category { Id = 8, Name = "Healthcare", Description = "Healthcare related jobs" },
                new Category { Id = 9, Name = "Education", Description = "Education related jobs" },
                new Category { Id = 10, Name = "Sales", Description = "Sales related jobs" },
                new Category { Id = 11, Name = "Customer Support", Description = "Customer Support related jobs" }
            );

            //Insert Job data
            modelBuilder.Entity<Job>().HasData(
                new Job { Id = 1, Name = "Software Engineer", Description = "Develop software applications", CategoryId = 1, Type = "Full Time", Position = "Employee" },
                new Job { Id = 3, Name = "Software Developer", Description = "Develop software solutions", CategoryId = 1, Type = "Full Time", Position = "Developer" },
                new Job { Id = 4, Name = "Software Engineer", Description = "Engineer software systems", CategoryId = 1, Type = "Full Time", Position = "Engineer" },
                new Job { Id = 5, Name = "Backend Developer", Description = "Work on backend systems", CategoryId = 1, Type = "Full Time", Position = "Developer" },
                new Job { Id = 6, Name = "Frontend Developer", Description = "Develop user interfaces", CategoryId = 1, Type = "Full Time", Position = "Developer" },
                //////
                new Job { Id = 2, Name = "UI Designer", Description = "Design user interfaces", CategoryId = 2, Type = "part time", Position = "Team Lead" },
                new Job { Id = 7, Name = "Graphic Designer", Description = "Design user interfaces", CategoryId = 2, Type = "Full Time", Position = "Designer" },
                new Job { Id = 8, Name = "UX Designer", Description = "Create user experiences", CategoryId = 2, Type = "Full Time", Position = "Designer" },
                new Job { Id = 9, Name = "Interaction Designer", Description = "Design interactive interfaces", CategoryId = 2, Type = "Full Time", Position = "Designer" },
                new Job { Id = 10, Name = "Visual Designer", Description = "Focus on visual aspects of design", CategoryId = 2, Type = "Full Time", Position = "Designer" },
                // Jobs for Software Testing category
                new Job { Id = 11, Name = "QA Tester", Description = "Test software applications", CategoryId = 3, Type = "Full Time", Position = "Tester" },
                new Job { Id = 12, Name = "Automation Tester", Description = "Automate testing processes", CategoryId = 3, Type = "Full Time", Position = "Tester" },
                new Job { Id = 13, Name = "Performance Tester", Description = "Test software performance", CategoryId = 3, Type = "Full Time", Position = "Tester" },
                new Job { Id = 14, Name = "Quality Analyst", Description = "Analyze software quality", CategoryId = 3, Type = "Full Time", Position = "Analyst" },
                // Jobs for Data Science category
                new Job { Id = 15, Name = "Data Scientist", Description = "Analyzing complex data sets", CategoryId = 4, Type = "Full Time", Position = "Scientist" },
                new Job { Id = 16, Name = "Machine Learning Engineer", Description = "Implement machine learning algorithms", CategoryId = 4, Type = "Full Time", Position = "Engineer" },
                new Job { Id = 17, Name = "Data Analyst", Description = "Analyze data to extract insights", CategoryId = 4, Type = "Full Time", Position = "Analyst" },
                new Job { Id = 18, Name = "Big Data Engineer", Description = "Manage and analyze large data sets", CategoryId = 4, Type = "Full Time", Position = "Engineer" },

                // Jobs for Digital Marketing category
                new Job { Id = 19, Name = "Digital Marketing Specialist", Description = "Plan and execute digital marketing campaigns", CategoryId = 5, Type = "Full Time", Position = "Specialist" },
                new Job { Id = 20, Name = "SEO Analyst", Description = "Optimize websites for search engines", CategoryId = 5, Type = "Full Time", Position = "Analyst" },
                new Job { Id = 21, Name = "Social Media Manager", Description = "Manage social media presence", CategoryId = 5, Type = "Full Time", Position = "Manager" },
                new Job { Id = 22, Name = "Content Marketing Specialist", Description = "Create engaging content for marketing purposes", CategoryId = 5, Type = "Full Time", Position = "Specialist" },

                // Jobs for Graphic Design category
                new Job { Id = 24, Name = "Graphic Designer", Description = "Create visual concepts", CategoryId = 6, Type = "Full Time", Position = "Designer" },
                new Job { Id = 25, Name = "Illustrator", Description = "Create illustrations and graphics", CategoryId = 6, Type = "Full Time", Position = "Illustrator" },
                new Job { Id = 26, Name = "Art Director", Description = "Oversee visual aspects of projects", CategoryId = 6, Type = "Full Time", Position = "Director" },
                new Job { Id = 27, Name = "Motion Graphics Designer", Description = "Create animated graphics and visual effects", CategoryId = 6, Type = "Full Time", Position = "Designer" },

                // Jobs for Financial Services category
                new Job { Id = 28, Name = "Financial Analyst", Description = "Analyze financial data and trends", CategoryId = 7, Type = "Full Time", Position = "Analyst" },
                new Job { Id = 29, Name = "Investment Banker", Description = "Manage investment portfolios", CategoryId = 7, Type = "Full Time", Position = "Banker" },
                new Job { Id = 30, Name = "Financial Advisor", Description = "Provide financial advice to clients", CategoryId = 7, Type = "Full Time", Position = "Advisor" },
                new Job { Id = 31, Name = "Accountant", Description = "Manage financial records and statements", CategoryId = 7, Type = "Full Time", Position = "Accountant" },
                // Jobs for Healthcare category
                new Job { Id = 32, Name = "Registered Nurse", Description = "Provide patient care", CategoryId = 8, Type = "Full Time", Position = "Nurse" },
                new Job { Id = 33, Name = "Medical Doctor", Description = "Diagnose and treat medical conditions", CategoryId = 8, Type = "Full Time", Position = "Doctor" },
                new Job { Id = 34, Name = "Medical Assistant", Description = "Assist healthcare professionals", CategoryId = 8, Type = "Full Time", Position = "Assistant" },
                new Job { Id = 35, Name = "Pharmacist", Description = "Dispense medications and provide information", CategoryId = 8, Type = "Full Time", Position = "Pharmacist" },

                // Jobs for Education category
                new Job { Id = 36, Name = "Teacher", Description = "Educate students in a specific subject area", CategoryId = 9, Type = "Full Time", Position = "Teacher" },
                new Job { Id = 37, Name = "Principal", Description = "Oversee school operations and staff", CategoryId = 9, Type = "Full Time", Position = "Principal" },
                new Job { Id = 38, Name = "Guidance Counselor", Description = "Provide academic and personal guidance to students", CategoryId = 9, Type = "Full Time", Position = "Counselor" },
                new Job { Id = 39, Name = "Librarian", Description = "Manage library resources and assist patrons", CategoryId = 9, Type = "Full Time", Position = "Librarian" },

                // Jobs for Sales category
                new Job { Id = 40, Name = "Sales Representative", Description = "Sell products or services to customers", CategoryId = 10, Type = "Full Time", Position = "Representative" },
                new Job { Id = 41, Name = "Sales Manager", Description = "Oversee sales team and strategies", CategoryId = 10, Type = "Full Time", Position = "Manager" },
                new Job { Id = 42, Name = "Account Executive", Description = "Manage client accounts and relationships", CategoryId = 10, Type = "Full Time", Position = "Executive" },
                new Job { Id = 43, Name = "Business Development Representative", Description = "Identify and develop business opportunities", CategoryId = 10, Type = "Full Time", Position = "Representative" },

                // Jobs for Customer Support category
                new Job { Id = 44, Name = "Customer Support Specialist", Description = "Assist customers with product inquiries and issues", CategoryId = 11, Type = "Full Time", Position = "Specialist" },
                new Job { Id = 45, Name = "Technical Support Engineer", Description = "Provide technical assistance to customers", CategoryId = 11, Type = "Full Time", Position = "Engineer" },
                new Job { Id = 46, Name = "Customer Service Representative", Description = "Handle customer inquiries and complaints", CategoryId = 11, Type = "Full Time", Position = "Representative" },
                new Job { Id = 47, Name = "Support Manager", Description = "Manage customer support team and operations", CategoryId = 11, Type = "Full Time", Position = "Manager" }
            );

            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
           UseSqlServer("Data Source=.;Initial Catalog=ProjectMVC;Integrated Security=True;Trust Server Certificate = False;Encrypt = False;");
        }




    }
}
