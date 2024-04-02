using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectMVC.Migrations
{
    /// <inheritdoc />
    public partial class up2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplyForJobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplyForJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplyForJobs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplyForJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Software development related jobs", "Software Development" },
                    { 2, "UI/UX design related jobs", "UI/UX Design" },
                    { 3, "Software Testing  related jobs", "Software Testing" },
                    { 4, "Data Science related jobs", "Data Science" },
                    { 5, "Digital Marketing related jobs", "Digital Marketing" },
                    { 6, "Graphic Design related jobs", "Graphic Design" },
                    { 7, "Financial Services related jobs", "Financial Services" },
                    { 8, "Healthcare related jobs", "Healthcare" },
                    { 9, "Education related jobs", "Education" },
                    { 10, "Sales related jobs", "Sales" },
                    { 11, "Customer Support related jobs", "Customer Support" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DateTime", "Description", "Image", "Location", "Name", "Position", "Salary", "Type" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop software applications", null, "Assiut", "Software Engineer", "Employee", 50000.0, "Full Time" },
                    { 2, 2, null, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Design user interfaces", null, "Assiut", "UI Designer", "Team Lead", 98000.0, "Part time" },
                    { 3, 1, null, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop software solutions", null, "Cario", "Software Developer", "Developer", 9800.0, "Part Time" },
                    { 4, 1, null, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineer software systems", null, "SmartVillage", "Software Engineer", "Engineer", 12000.0, "Full Time" },
                    { 5, 1, null, new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work on backend systems", null, "Sohag", "Backend Developer", "Developer", 30000.0, "Part Time" },
                    { 6, 1, null, new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop user interfaces", null, "Minya", "Frontend Developer", "Developer", 9800.0, "Full Time" },
                    { 7, 2, null, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Design user interfaces", null, "Minyfia", "Graphic Designer", "Designer", 40000.0, "Full Time" },
                    { 8, 2, null, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create user experiences", null, "Alexandria", "UX Designer", "Designer", 9000.0, "Full Time" },
                    { 9, 2, null, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Design interactive interfaces", null, "Cario", "Interaction Designer", "Designer", 9800.0, "Full Time" },
                    { 10, 2, null, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Focus on visual aspects of design", null, "Elgharbia", "Visual Designer", "Designer", 9800.0, "Part Time" },
                    { 11, 3, null, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test software applications", null, "Cario", "QA Tester", "Tester", 9400.0, "Part Time" },
                    { 12, 3, null, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automate testing processes", null, "Cario", "Automation Tester", "Tester", 9800.0, "Full Time" },
                    { 13, 3, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test software performance", null, "Assiut", "Performance Tester", "Tester", 29200.0, "Full Time" },
                    { 14, 3, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analyze software quality", null, "Cairo", "Quality Analyst", "Analyst", 29900.0, "Full Time" },
                    { 15, 4, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analyzing complex data sets", null, "Assiut", "Data Scientist", "Scientist", 29200.0, "Full Time" },
                    { 16, 4, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Implement machine learning algorithms", null, "Assiut", "Machine Learning Engineer", "Engineer", 29200.0, "Part Time" },
                    { 17, 4, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analyze data to extract insights", null, "Assiut", "Data Analyst", "Analyst", 29200.0, "Full Time" },
                    { 18, 4, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage and analyze large data sets", null, "Assiut", "Big Data Engineer", "Engineer", 29200.0, "Part Time" },
                    { 19, 5, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plan and execute digital marketing campaigns", null, "Assiut", "Digital Marketing Specialist", "Specialist", 29200.0, "Full Time" },
                    { 20, 5, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Optimize websites for search engines", null, "Assiut", "SEO Analyst", "Analyst", 29200.0, "Full Time" },
                    { 21, 5, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage social media presence", null, "Assiut", "Social Media Manager", "Manager", 29200.0, "Full Time" },
                    { 22, 5, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create engaging content for marketing purposes", null, "Assiut", "Content Marketing Specialist", "Specialist", 29200.0, "Part Time" },
                    { 24, 6, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create visual concepts", null, "Assiut", "Graphic Designer", "Designer", 29200.0, "Full Time" },
                    { 25, 6, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create illustrations and graphics", null, "Assiut", "Illustrator", "Illustrator", 29200.0, "Part Time" },
                    { 26, 6, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oversee visual aspects of projects", null, "Assiut", "Art Director", "Director", 29200.0, "Full Time" },
                    { 27, 6, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create animated graphics and visual effects", null, "Assiut", "Motion Graphics Designer", "Designer", 29200.0, "Part Time" },
                    { 28, 7, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analyze financial data and trends", null, "Assiut", "Financial Analyst", "Analyst", 29200.0, "Full Time" },
                    { 29, 7, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage investment portfolios", null, "Assiut", "Investment Banker", "Banker", 29200.0, "Part Time" },
                    { 30, 7, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provide financial advice to clients", null, "Assiut", "Financial Advisor", "Advisor", 29200.0, "Full Time" },
                    { 31, 7, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage financial records and statements", null, "Assiut", "Accountant", "Accountant", 29200.0, "Full Time" },
                    { 32, 8, null, null, "Provide patient care", null, null, "Registered Nurse", "Nurse", 0.0, "Full Time" },
                    { 33, 8, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diagnose and treat medical conditions", null, "Assiut", "Medical Doctor", "Doctor", 29200.0, "Full Time" },
                    { 34, 8, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assist healthcare professionals", null, "Assiut", "Medical Assistant", "Assistant", 29200.0, "Full Time" },
                    { 35, 8, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispense medications and provide information", null, "Assiut", "Pharmacist", "Pharmacist", 29200.0, "Full Time" },
                    { 36, 9, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Educate students in a specific subject area", null, "Assiut", "Teacher", "Teacher", 29200.0, "Full Time" },
                    { 37, 9, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oversee school operations and staff", null, "Assiut", "Principal", "Principal", 29200.0, "Full Time" },
                    { 38, 9, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provide academic and personal guidance to students", null, "Assiut", "Guidance Counselor", "Counselor", 29200.0, "Full Time" },
                    { 39, 9, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage library resources and assist patrons", null, "Assiut", "Librarian", "Librarian", 29200.0, "Full Time" },
                    { 40, 10, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sell products or services to customers", null, "Assiut", "Sales Representative", "Representative", 29200.0, "Full Time" },
                    { 41, 10, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oversee sales team and strategies", null, "Assiut", "Sales Manager", "Manager", 29200.0, "Full Time" },
                    { 42, 10, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage client accounts and relationships", null, "Assiut", "Account Executive", "Executive", 29200.0, "Full Time" },
                    { 43, 10, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identify and develop business opportunities", null, "Assiut", "Business Development Representative", "Representative", 29200.0, "Full Time" },
                    { 44, 11, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assist customers with product inquiries and issues", null, "Assiut", "Customer Support Specialist", "Specialist", 29200.0, "Full Time" },
                    { 45, 11, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provide technical assistance to customers", null, "Assiut", "Technical Support Engineer", "Engineer", 29200.0, "Full Time" },
                    { 46, 11, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handle customer inquiries and complaints", null, "Assiut", "Customer Service Representative", "Representative", 29200.0, "Full Time" },
                    { 47, 11, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage customer support team and operations", null, "Luxor", "Support Manager", "Manager", 29200.0, "Full Time" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplyForJobs_JobId",
                table: "ApplyForJobs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplyForJobs_UserId",
                table: "ApplyForJobs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CategoryId",
                table: "Jobs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CompanyId",
                table: "Jobs",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplyForJobs");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companys");
        }
    }
}
