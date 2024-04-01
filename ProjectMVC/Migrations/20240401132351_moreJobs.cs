using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectMVC.Migrations
{
    /// <inheritdoc />
    public partial class moreJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DateTime", "Description", "Image", "Name", "Position", "Type" },
                values: new object[,]
                {
                    { 3, 1, null, null, "Develop software solutions", null, "Software Developer", "Developer", "Full Time" },
                    { 4, 1, null, null, "Engineer software systems", null, "Software Engineer", "Engineer", "Full Time" },
                    { 5, 1, null, null, "Work on backend systems", null, "Backend Developer", "Developer", "Full Time" },
                    { 6, 1, null, null, "Develop user interfaces", null, "Frontend Developer", "Developer", "Full Time" },
                    { 7, 2, null, null, "Design user interfaces", null, "Graphic Designer", "Designer", "Full Time" },
                    { 8, 2, null, null, "Create user experiences", null, "UX Designer", "Designer", "Full Time" },
                    { 9, 2, null, null, "Design interactive interfaces", null, "Interaction Designer", "Designer", "Full Time" },
                    { 10, 2, null, null, "Focus on visual aspects of design", null, "Visual Designer", "Designer", "Full Time" },
                    { 11, 3, null, null, "Test software applications", null, "QA Tester", "Tester", "Full Time" },
                    { 12, 3, null, null, "Automate testing processes", null, "Automation Tester", "Tester", "Full Time" },
                    { 13, 3, null, null, "Test software performance", null, "Performance Tester", "Tester", "Full Time" },
                    { 14, 3, null, null, "Analyze software quality", null, "Quality Analyst", "Analyst", "Full Time" },
                    { 15, 4, null, null, "Analyzing complex data sets", null, "Data Scientist", "Scientist", "Full Time" },
                    { 16, 4, null, null, "Implement machine learning algorithms", null, "Machine Learning Engineer", "Engineer", "Full Time" },
                    { 17, 4, null, null, "Analyze data to extract insights", null, "Data Analyst", "Analyst", "Full Time" },
                    { 18, 4, null, null, "Manage and analyze large data sets", null, "Big Data Engineer", "Engineer", "Full Time" },
                    { 19, 5, null, null, "Plan and execute digital marketing campaigns", null, "Digital Marketing Specialist", "Specialist", "Full Time" },
                    { 20, 5, null, null, "Optimize websites for search engines", null, "SEO Analyst", "Analyst", "Full Time" },
                    { 21, 5, null, null, "Manage social media presence", null, "Social Media Manager", "Manager", "Full Time" },
                    { 22, 5, null, null, "Create engaging content for marketing purposes", null, "Content Marketing Specialist", "Specialist", "Full Time" },
                    { 24, 6, null, null, "Create visual concepts", null, "Graphic Designer", "Designer", "Full Time" },
                    { 25, 6, null, null, "Create illustrations and graphics", null, "Illustrator", "Illustrator", "Full Time" },
                    { 26, 6, null, null, "Oversee visual aspects of projects", null, "Art Director", "Director", "Full Time" },
                    { 27, 6, null, null, "Create animated graphics and visual effects", null, "Motion Graphics Designer", "Designer", "Full Time" },
                    { 28, 7, null, null, "Analyze financial data and trends", null, "Financial Analyst", "Analyst", "Full Time" },
                    { 29, 7, null, null, "Manage investment portfolios", null, "Investment Banker", "Banker", "Full Time" },
                    { 30, 7, null, null, "Provide financial advice to clients", null, "Financial Advisor", "Advisor", "Full Time" },
                    { 31, 7, null, null, "Manage financial records and statements", null, "Accountant", "Accountant", "Full Time" },
                    { 32, 8, null, null, "Provide patient care", null, "Registered Nurse", "Nurse", "Full Time" },
                    { 33, 8, null, null, "Diagnose and treat medical conditions", null, "Medical Doctor", "Doctor", "Full Time" },
                    { 34, 8, null, null, "Assist healthcare professionals", null, "Medical Assistant", "Assistant", "Full Time" },
                    { 35, 8, null, null, "Dispense medications and provide information", null, "Pharmacist", "Pharmacist", "Full Time" },
                    { 36, 9, null, null, "Educate students in a specific subject area", null, "Teacher", "Teacher", "Full Time" },
                    { 37, 9, null, null, "Oversee school operations and staff", null, "Principal", "Principal", "Full Time" },
                    { 38, 9, null, null, "Provide academic and personal guidance to students", null, "Guidance Counselor", "Counselor", "Full Time" },
                    { 39, 9, null, null, "Manage library resources and assist patrons", null, "Librarian", "Librarian", "Full Time" },
                    { 40, 10, null, null, "Sell products or services to customers", null, "Sales Representative", "Representative", "Full Time" },
                    { 41, 10, null, null, "Oversee sales team and strategies", null, "Sales Manager", "Manager", "Full Time" },
                    { 42, 10, null, null, "Manage client accounts and relationships", null, "Account Executive", "Executive", "Full Time" },
                    { 43, 10, null, null, "Identify and develop business opportunities", null, "Business Development Representative", "Representative", "Full Time" },
                    { 44, 11, null, null, "Assist customers with product inquiries and issues", null, "Customer Support Specialist", "Specialist", "Full Time" },
                    { 45, 11, null, null, "Provide technical assistance to customers", null, "Technical Support Engineer", "Engineer", "Full Time" },
                    { 46, 11, null, null, "Handle customer inquiries and complaints", null, "Customer Service Representative", "Representative", "Full Time" },
                    { 47, 11, null, null, "Manage customer support team and operations", null, "Support Manager", "Manager", "Full Time" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 47);
        }
    }
}
