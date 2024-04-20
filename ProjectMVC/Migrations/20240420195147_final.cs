using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectMVC.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureProfile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
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
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Responsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    portfolio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplyForJobs", x => x.Id);
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
                columns: new[] { "Id", "CategoryId", "CompanyId", "DateTime", "Description", "Image", "Location", "Name", "Position", "Qualifications", "Responsibility", "Salary", "Type" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop software applications", null, "Assiut", "Software Engineer", "Employee", "Qualifications for a software engineer typically include ,a bachelor's degree in computer science, software engineering, or a related field. Some employers may also require a master's degree for more advanced positions. In addition to formal education, relevant skills in programming languages, software development, problem-solving, and teamwork are essential. Many software engineers also benefit from industry certifications and continuous learning to stay updated with the latest technologies and best practices.", "The responsibilities of a software engineer often include, designing, developing, and testing software solutions, as well as collaborating with cross-functional teams to understand requirements and deliver high-quality products. Software engineers are also responsible for maintaining and enhancing existing software, debugging and troubleshooting issues, and staying updated with industry best practices and technological advancements. Additionally, they may be involved in documenting software specifications, providing technical support, and participating in code reviews to ensure quality and efficiency.", 50000.0, "Full Time" },
                    { 2, 2, null, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Design user interfaces", null, "Assiut", "UI Designer", "Team Lead", "Proven experience as a UI Designer or similar role. Strong portfolio of design projects. Proficiency in visual design and wire-framing tools. Knowledge of HTML/CSS; JavaScript is a plus. Problem-solving mindset and a keen eye for detail.", "Gather and evaluate user requirements in collaboration with product managers and engineers. Design graphic user interface elements, like menus, tabs, and widgets. Develop UI mockups and prototypes that clearly illustrate how sites function and look. Adhere to style standards on fonts, colors, and images. Provide guidance and mentorship to junior team members.", 98000.0, "Part time" },
                    { 3, 1, null, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop software solutions", null, "Cario", "Software Developer", "Developer", "Qualifications for a software developer typically include a bachelor's degree in computer science, software engineering, or a related field. Strong programming skills, knowledge of software development methodologies, and the ability to work in a team environment are essential. Some employers may also prefer candidates with experience in specific programming languages and tools, as well as a strong understanding of software design principles and best practices.", "The responsibilities of a software developer often include participating in the entire software development lifecycle, from concept and design to testing and maintenance. Software developers collaborate with stakeholders to understand requirements, write clean and efficient code, troubleshoot and debug software issues, and continuously improve software functionality. They may also be involved in documenting software specifications, conducting code reviews, and staying updated with industry trends and advancements.", 9800.0, "Part Time" },
                    { 4, 1, null, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineer software systems", null, "SmartVillage", "Software Engineer", "Engineer", "Bachelor's or master's degree in Computer Science, Software Engineering, or related field. Proven experience in software development methodologies and best practices. Proficient in multiple programming languages and frameworks relevant to the organization's tech stack. Strong analytical and problem-solving skills. Excellent communication and teamwork abilities.", "Design, develop, test, and maintain software systems to meet client or stakeholder requirements. Collaborate with team members to identify system requirements and integrate software components. Write clean, scalable, and efficient code. Troubleshoot, debug, and upgrade existing systems. Document development phases and monitor systems.", 12000.0, "Full Time" },
                    { 5, 1, null, new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work on backend systems", null, "Sohag", "Backend Developer", "Developer", "Bachelor's degree in Computer Science or related field. Strong understanding of server-side languages such as Java, Python, Ruby, .NET, etc. Experience with database technology such as MySQL, Oracle, and MongoDB. Familiarity with cloud services and API integration. Excellent problem-solving skills and ability to think algorithmically.", "Develop and maintain the server-side logic of web applications and databases. Ensure high performance and responsiveness to requests from the front-end. Participate in the entire application lifecycle, focusing on coding, debugging, and providing user support. Create data protection and security settings. Write technical documentation.", 30000.0, "Part Time" },
                    { 6, 1, null, new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop user interfaces", null, "Minya", "Frontend Developer", "Developer", "Bachelor's degree in Computer Science, or similar. Proficiency with HTML, CSS, and JavaScript. Experience with front-end development frameworks (e.g., React, Angular, Vue). Understanding of web design principles and UX/UI best practices. Familiarity with version control tools like Git.", "Develop new user-facing features and build reusable code and libraries for future use. Ensure the technical feasibility of UI/UX designs. Optimize application for maximum speed and scalability. Assure that all user input is validated before submitting to back-end services. Collaborate with other team members and stakeholders.", 9800.0, "Full Time" },
                    { 7, 2, null, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Design user interfaces", null, "Minyfia", "Graphic Designer", "Designer", "Bachelor's degree in Graphic Design or related field. Proven graphic designing experience with a strong portfolio. Proficiency in Photoshop, Illustrator, InDesign, and other visual design and wire-framing tools. Exceptional creativity and innovation. Excellent time management and organizational skills.", "Conceptualize visuals based on requirements. Prepare rough drafts and present ideas. Develop illustrations, logos, and other designs using software. Use appropriate colors and layouts for each graphic. Work with copywriters and creative director to produce the final design.", 40000.0, "Full Time" },
                    { 8, 2, null, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create user experiences", null, "Alexandria", "UX Designer", "Designer", "Strong understanding of UX principles and best practices. Experience with user research, wireframes, and prototypes. Proficiency in UX design software such as Sketch, Adobe XD, or Figma. Excellent communication skills to collaborate with team members and stakeholders. Ability to solve problems creatively and effectively.", "Conduct user research and testing. Develop wireframes and task flows based on user needs. Collaborate with designers and developers to create intuitive, user-friendly software. Communicate design ideas and prototypes to developers. Keep abreast of competitor products and industry trends.", 9000.0, "Full Time" },
                    { 9, 2, null, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Design interactive interfaces", null, "Cairo", "Interaction Designer", "Designer", "Bachelor's degree in Design, Computer Science, or relevant field. Proven experience as an Interaction Designer or similar role. Strong portfolio of design projects. Proficient in design software and interactive design tools. Excellent communication skills to collaborate with various stakeholders.", "Develop interactive design elements and architecture for digital platforms. Create user-focused concepts and interactive solutions. Work closely with UI designers and developers to implement interactive designs. Test and refine designs based on user feedback and data. Stay updated with the latest trends in interaction design and technology.", 9800.0, "Full Time" },
                    { 10, 2, null, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Focus on visual aspects of design", null, "Elgharbia", "Visual Designer", "Designer", "Proven experience as a Visual Designer, Graphic Designer, or similar role. Strong portfolio of visual design projects. Proficiency in graphic design software including Adobe Photoshop, Adobe Illustrator, and other visual design tools. Excellent visual design skills with sensitivity to user-system interaction. Ability to present and defend designs and key deliverables to peers and executive level stakeholders.", "Develop visual elements for websites, applications, and other digital platforms. Create images, icons, and layouts according to design guidelines. Work with the design team to define and implement innovative solutions for the product direction, visuals, and experience. Execute all visual design stages from concept to final hand-off to engineering. Conceptualize original ideas that bring simplicity and user friendliness to complex design roadblocks.", 9800.0, "Part Time" },
                    { 11, 3, null, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test software applications", null, "Cario", "QA Tester", "Tester", "Qualifications for a QA Tester include a bachelor's degree in computer science, information technology, or a related field. Proficiency in various testing methodologies and tools, attention to detail, and strong analytical skills are essential. Experience with automated testing tools and a basic understanding of programming languages are advantageous.", "Responsibilities of a QA Tester involve designing, developing, and executing test cases to ensure the quality of software applications. They detect bugs and issues, provide detailed bug reports, and collaborate with the development team to resolve issues. QA Testers also participate in the development process to understand requirements and ensure compliance with quality standards.", 9400.0, "Part Time" },
                    { 12, 3, null, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automate testing processes", null, "Cario", "Automation Tester", "Tester", "Qualifications for an Automation Tester include a bachelor’s degree in computer science, engineering, or related field. Strong programming skills and experience with automation tools like Selenium or QTP are required. Understanding of software development methodologies and experience with CI/CD tools are beneficial.", "Responsibilities include designing and implementing automated testing frameworks, writing and executing test scripts, identifying and logging defects, and working with the development team to resolve them. Automation Testers also maintain and enhance test automation environments and integrate automation tests with the CI/CD pipeline.", 9800.0, "Full Time" },
                    { 13, 3, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test software performance", null, "Assiut", "Performance Tester", "Tester", "Qualifications include a bachelor's degree in computer science or a related field, with a strong understanding of performance testing methodologies and tools (e.g., LoadRunner, JMeter). Knowledge of programming and scripting languages, and experience with system monitoring tools are important.", "Responsibilities involve planning, designing, and implementing performance tests to ensure software applications meet performance criteria. This includes analyzing test results, identifying bottlenecks, and working closely with developers to optimize performance.", 29200.0, "Full Time" },
                    { 14, 3, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analyze software quality", null, "Cairo", "Quality Analyst", "Analyst", "Qualifications for a Quality Analyst include a bachelor's degree in computer science, IT, or a related field, with a deep understanding of QA methodologies. Strong analytical skills, attention to detail, and experience with QA tools and processes are essential.", "The main responsibilities include analyzing software products to ensure they meet quality standards and user requirements. This involves developing and executing test plans, documenting defects, and collaborating with development teams to resolve issues.", 29900.0, "Full Time" },
                    { 15, 4, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analyzing complex data sets", null, "Assiut", "Data Scientist", "Scientist", "A Data Scientist typically holds a master’s or Ph.D. in data science, statistics, computer science, or a related field. Essential skills include proficiency in programming languages like Python or R, experience with data visualization tools, and a strong foundation in machine learning and statistical analysis.", "Responsibilities include collecting, processing, and analyzing large data sets to identify trends and patterns. Data Scientists develop predictive models, algorithms, and conduct experiments to test their effectiveness. They also communicate findings to stakeholders and provide insights to inform decision-making.", 29200.0, "Full Time" },
                    { 16, 4, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Implement machine learning algorithms", null, "Assiut", "Machine Learning Engineer", "Engineer", "Qualifications include a degree in computer science, mathematics, or a related technical field. Proficiency in programming languages such as Python or Java, and experience with machine learning frameworks (e.g., TensorFlow, PyTorch) are required. A strong mathematical background is also important.", "Machine Learning Engineers are responsible for designing and implementing machine learning models. They work on data preprocessing, model training, testing, and deployment. Collaborating with data scientists and software engineers to integrate models into production systems is also part of their role.", 29200.0, "Part Time" },
                    { 17, 4, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analyze data to extract insights", null, "Assiut", "Data Analyst", "Analyst", "A Data Analyst typically holds a bachelor's degree in information technology, computer science, or a related field. Proficiency in SQL, Excel, and data visualization tools like Tableau or Power BI is required. Analytical thinking and problem-solving skills are essential.", "Data Analysts collect and interpret data to identify trends, patterns, and insights. They create reports and dashboards for stakeholders, helping to drive decision-making and strategic planning. Ensuring data accuracy and providing recommendations based on data analysis are key responsibilities.", 29200.0, "Full Time" },
                    { 18, 4, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage and analyze large data sets", null, "Assiut", "Big Data Engineer", "Engineer", "Bachelor's degree in Computer Science or related field\nExperience with big data technologies\nStrong analytical skills", "Develop and manage big data solutions\nAnalyze data sets to identify insights\nEnsure data security and privacy", 29200.0, "Part Time" },
                    { 19, 5, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plan and execute digital marketing campaigns", null, "Assiut", "Digital Marketing Specialist", "Specialist", "Bachelor's degree in Marketing or related field\nExperience with digital marketing tools and platforms\nStrong communication and analytical skills", "Plan and execute digital marketing campaigns\nMonitor and analyze campaign performance\nCollaborate with other teams to integrate marketing strategies", 29200.0, "Full Time" },
                    { 20, 5, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Optimize websites for search engines", null, "Assiut", "SEO Analyst", "Analyst", "Proven experience as SEO Analyst\nKnowledge of SEO practices and analytics tools\nExcellent communication skills", "Perform ongoing keyword research\nOptimize website content for search engines\nTrack and analyze website analytics", 29200.0, "Full Time" },
                    { 21, 5, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage social media presence", null, "Assiut", "Social Media Manager", "Manager", "Experience with social media management\nStrong communication and creative skills\nAbility to analyze performance metrics", "Develop and implement social media strategy\nCreate and distribute engaging content\nMonitor and report on performance metrics", 29200.0, "Full Time" },
                    { 22, 5, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create engaging content for marketing purposes", null, "Assiut", "Content Marketing Specialist", "Specialist", "Proven content creation experience\nExcellent writing and editing skills\nUnderstanding of marketing strategies", "Develop content strategy aligned with marketing targets\nCreate and publish engaging content\nAnalyze content performance and adjust strategies as needed", 29200.0, "Part Time" },
                    { 24, 6, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create visual concepts", null, "Assiut", "Graphic Designer", "Designer", "Bachelor's degree in Graphic Design or related field\nProficiency in graphic design software\nCreative thinking and attention to detail", "Create visual aspects of marketing materials, websites, and other media\nWork with clients or the art director to determine the scope of a project\nUse digital illustration, photo editing software, and layout software to create designs", 29200.0, "Full Time" },
                    { 25, 6, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create illustrations and graphics", null, "Assiut", "Illustrator", "Illustrator", "Strong portfolio of illustrations or other graphics\nFamiliarity with design software and technologies\nA keen eye for aesthetics and details", "Create original pieces of artwork for digital or print\nUse various colors, graphics and effects to better visualize each concept\nParticipate in design briefs with clients, editors, or marketers to identify their needs", 29200.0, "Part Time" },
                    { 26, 6, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oversee visual aspects of projects", null, "Assiut", "Art Director", "Director", "Proven experience as an Art Director\nStrong portfolio showcasing high-end digital design skills\nAbility to think creatively and provide marketable solutions", "Determine the best way to represent a concept visually\nDecide which photographs, art, or other design elements to use\nDevelop the overall look or style of a publication, an advertising campaign, or a theater, television, or film set", 29200.0, "Full Time" },
                    { 27, 6, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create animated graphics and visual effects", null, "Assiut", "Motion Graphics Designer", "Designer", "Demonstrable graphic design skills with a strong portfolio\nProficiency with required desktop publishing tools, including Photoshop, After Effects, and Adobe Animate\nA strong eye for visual composition", "Design and create enticing motion graphics for video deliverables (corporate videos, websites, marketing demos, etc.)\nPrepare design plan, concept, and layout for motion graphic project\nAssist in selecting audio, video, colors, animation, etc. for graphic design", 29200.0, "Part Time" },
                    { 28, 7, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analyze financial data and trends", null, "Assiut", "Financial Analyst", "Analyst", "Bachelor's degree in Finance, Accounting, or related field\nExperience with financial modeling and statistical analysis\nStrong analytical and data gathering skills", "Analyze financial data to identify trends and make recommendations\nPrepare financial reports and forecasts\nEvaluate investment opportunities and provide recommendations", 29200.0, "Full Time" },
                    { 29, 7, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage investment portfolios", null, "Assiut", "Investment Banker", "Banker", "Bachelor's degree in Finance, Economics, or related field\nStrong analytical and quantitative skills\nExcellent communication and interpersonal skills", "Advise clients on investment opportunities and strategies\nManage and structure financial deals\nConduct financial analysis and market research", 29200.0, "Part Time" },
                    { 30, 7, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provide financial advice to clients", null, "Assiut", "Financial Advisor", "Advisor", "Bachelor's degree in Finance, Economics, or a related field\nCertification as a Certified Financial Planner (CFP) preferred\nStrong understanding of the financial market and investment strategies", "Assess clients' financial situations and understand their needs\nProvide personalized financial advice and investment solutions\nMonitor and review clients' accounts and adjust plans as necessary", 29200.0, "Full Time" },
                    { 31, 7, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage financial records and statements", null, "Assiut", "Accountant", "Accountant", "Bachelor's degree in Accounting or related field\nCertification (e.g., CPA) is a plus\nProven experience as an accountant", "Prepare accurate financial statements and reports\nEnsure compliance with financial laws and regulations\nManage all accounting transactions and audit financial transactions and documents", 29200.0, "Full Time" },
                    { 32, 8, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provide patient care", null, "Assiut", "Registered Nurse", "Nurse", "Bachelor of Science in Nursing (BSN) degree\nActive Registered Nurse license\nProven experience as a registered nurse", "Provide direct patient care and assess their conditions\nAdminister medications and treatments\nEducate patients and their families on health plans and preventive care", 29200.0, "Full Time" },
                    { 33, 8, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diagnose and treat medical conditions", null, "Assiut", "Medical Doctor", "Doctor", "Medical degree from a recognized university\nValid license to practice the profession\nProven experience as a Medical Doctor", "Diagnose patient conditions using examinations and tests\nPrescribe and administer treatment\nAdvise patients on health and preventive care", 29200.0, "Full Time" },
                    { 34, 8, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assist healthcare professionals", null, "Assiut", "Medical Assistant", "Assistant", "Proven experience as a medical assistant or in a similar role\nKnowledge of healthcare operations and medical terminology\nStrong organizational and communication skills", "Assist in examining and treating patients under the direction of a physician\nPrepare patients for examinations and perform routine diagnostic checks\nManage medical supplies and keep detailed records of all patient interactions", 29200.0, "Full Time" },
                    { 35, 8, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispense medications and provide information", null, "Assiut", "Pharmacist", "Pharmacist", "Degree in Pharmacy or Pharmacology\nValid pharmacist license\nProven experience as a pharmacist", "Dispense medications accurately and ensure safety and quality standards are met\nProvide information to patients about medications and their use\nManage inventory and perform administrative tasks", 29200.0, "Full Time" },
                    { 36, 9, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Educate students in a specific subject area", null, "Assiut", "Teacher", "Teacher", null, null, 29200.0, "Full Time" },
                    { 37, 9, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oversee school operations and staff", null, "Assiut", "Principal", "Principal", null, null, 29200.0, "Full Time" },
                    { 38, 9, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provide academic and personal guidance to students", null, "Assiut", "Guidance Counselor", "Counselor", null, null, 29200.0, "Full Time" },
                    { 39, 9, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage library resources and assist patrons", null, "Assiut", "Librarian", "Librarian", null, null, 29200.0, "Full Time" },
                    { 40, 10, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sell products or services to customers", null, "Assiut", "Sales Representative", "Representative", null, null, 29200.0, "Full Time" },
                    { 41, 10, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oversee sales team and strategies", null, "Assiut", "Sales Manager", "Manager", null, null, 29200.0, "Full Time" },
                    { 42, 10, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage client accounts and relationships", null, "Assiut", "Account Executive", "Executive", null, null, 29200.0, "Full Time" },
                    { 43, 10, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identify and develop business opportunities", null, "Assiut", "Business Development Representative", "Representative", null, null, 29200.0, "Full Time" },
                    { 44, 11, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assist customers with product inquiries and issues", null, "Assiut", "Customer Support Specialist", "Specialist", null, null, 29200.0, "Full Time" },
                    { 45, 11, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Provide technical assistance to customers", null, "Assiut", "Technical Support Engineer", "Engineer", null, null, 29200.0, "Full Time" },
                    { 46, 11, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handle customer inquiries and complaints", null, "Assiut", "Customer Service Representative", "Representative", null, null, 29200.0, "Full Time" },
                    { 47, 11, null, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manage customer support team and operations", null, "Luxor", "Support Manager", "Manager", null, null, 29200.0, "Full Time" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplyForJobs_JobId",
                table: "ApplyForJobs",
                column: "JobId");

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
                name: "Contacts");

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
