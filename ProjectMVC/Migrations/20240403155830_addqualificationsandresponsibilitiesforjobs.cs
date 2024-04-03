using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMVC.Migrations
{
    /// <inheritdoc />
    public partial class addqualificationsandresponsibilitiesforjobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Qualifications",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Responsibility",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Qualifications for a software engineer typically include ,a bachelor's degree in computer science, software engineering, or a related field. Some employers may also require a master's degree for more advanced positions. In addition to formal education, relevant skills in programming languages, software development, problem-solving, and teamwork are essential. Many software engineers also benefit from industry certifications and continuous learning to stay updated with the latest technologies and best practices.", "The responsibilities of a software engineer often include, designing, developing, and testing software solutions, as well as collaborating with cross-functional teams to understand requirements and deliver high-quality products. Software engineers are also responsible for maintaining and enhancing existing software, debugging and troubleshooting issues, and staying updated with industry best practices and technological advancements. Additionally, they may be involved in documenting software specifications, providing technical support, and participating in code reviews to ensure quality and efficiency." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Proven experience as a UI Designer or similar role. Strong portfolio of design projects. Proficiency in visual design and wire-framing tools. Knowledge of HTML/CSS; JavaScript is a plus. Problem-solving mindset and a keen eye for detail.", "Gather and evaluate user requirements in collaboration with product managers and engineers. Design graphic user interface elements, like menus, tabs, and widgets. Develop UI mockups and prototypes that clearly illustrate how sites function and look. Adhere to style standards on fonts, colors, and images. Provide guidance and mentorship to junior team members." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Qualifications for a software developer typically include a bachelor's degree in computer science, software engineering, or a related field. Strong programming skills, knowledge of software development methodologies, and the ability to work in a team environment are essential. Some employers may also prefer candidates with experience in specific programming languages and tools, as well as a strong understanding of software design principles and best practices.", "The responsibilities of a software developer often include participating in the entire software development lifecycle, from concept and design to testing and maintenance. Software developers collaborate with stakeholders to understand requirements, write clean and efficient code, troubleshoot and debug software issues, and continuously improve software functionality. They may also be involved in documenting software specifications, conducting code reviews, and staying updated with industry trends and advancements." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Bachelor's or master's degree in Computer Science, Software Engineering, or related field. Proven experience in software development methodologies and best practices. Proficient in multiple programming languages and frameworks relevant to the organization's tech stack. Strong analytical and problem-solving skills. Excellent communication and teamwork abilities.", "Design, develop, test, and maintain software systems to meet client or stakeholder requirements. Collaborate with team members to identify system requirements and integrate software components. Write clean, scalable, and efficient code. Troubleshoot, debug, and upgrade existing systems. Document development phases and monitor systems." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Bachelor's degree in Computer Science or related field. Strong understanding of server-side languages such as Java, Python, Ruby, .NET, etc. Experience with database technology such as MySQL, Oracle, and MongoDB. Familiarity with cloud services and API integration. Excellent problem-solving skills and ability to think algorithmically.", "Develop and maintain the server-side logic of web applications and databases. Ensure high performance and responsiveness to requests from the front-end. Participate in the entire application lifecycle, focusing on coding, debugging, and providing user support. Create data protection and security settings. Write technical documentation." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Bachelor's degree in Computer Science, or similar. Proficiency with HTML, CSS, and JavaScript. Experience with front-end development frameworks (e.g., React, Angular, Vue). Understanding of web design principles and UX/UI best practices. Familiarity with version control tools like Git.", "Develop new user-facing features and build reusable code and libraries for future use. Ensure the technical feasibility of UI/UX designs. Optimize application for maximum speed and scalability. Assure that all user input is validated before submitting to back-end services. Collaborate with other team members and stakeholders." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Bachelor's degree in Graphic Design or related field. Proven graphic designing experience with a strong portfolio. Proficiency in Photoshop, Illustrator, InDesign, and other visual design and wire-framing tools. Exceptional creativity and innovation. Excellent time management and organizational skills.", "Conceptualize visuals based on requirements. Prepare rough drafts and present ideas. Develop illustrations, logos, and other designs using software. Use appropriate colors and layouts for each graphic. Work with copywriters and creative director to produce the final design." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Strong understanding of UX principles and best practices. Experience with user research, wireframes, and prototypes. Proficiency in UX design software such as Sketch, Adobe XD, or Figma. Excellent communication skills to collaborate with team members and stakeholders. Ability to solve problems creatively and effectively.", "Conduct user research and testing. Develop wireframes and task flows based on user needs. Collaborate with designers and developers to create intuitive, user-friendly software. Communicate design ideas and prototypes to developers. Keep abreast of competitor products and industry trends." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Location", "Qualifications", "Responsibility" },
                values: new object[] { "Cairo", "Bachelor's degree in Design, Computer Science, or relevant field. Proven experience as an Interaction Designer or similar role. Strong portfolio of design projects. Proficient in design software and interactive design tools. Excellent communication skills to collaborate with various stakeholders.", "Develop interactive design elements and architecture for digital platforms. Create user-focused concepts and interactive solutions. Work closely with UI designers and developers to implement interactive designs. Test and refine designs based on user feedback and data. Stay updated with the latest trends in interaction design and technology." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Proven experience as a Visual Designer, Graphic Designer, or similar role. Strong portfolio of visual design projects. Proficiency in graphic design software including Adobe Photoshop, Adobe Illustrator, and other visual design tools. Excellent visual design skills with sensitivity to user-system interaction. Ability to present and defend designs and key deliverables to peers and executive level stakeholders.", "Develop visual elements for websites, applications, and other digital platforms. Create images, icons, and layouts according to design guidelines. Work with the design team to define and implement innovative solutions for the product direction, visuals, and experience. Execute all visual design stages from concept to final hand-off to engineering. Conceptualize original ideas that bring simplicity and user friendliness to complex design roadblocks." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Qualifications for a QA Tester include a bachelor's degree in computer science, information technology, or a related field. Proficiency in various testing methodologies and tools, attention to detail, and strong analytical skills are essential. Experience with automated testing tools and a basic understanding of programming languages are advantageous.", "Responsibilities of a QA Tester involve designing, developing, and executing test cases to ensure the quality of software applications. They detect bugs and issues, provide detailed bug reports, and collaborate with the development team to resolve issues. QA Testers also participate in the development process to understand requirements and ensure compliance with quality standards." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Qualifications for an Automation Tester include a bachelor’s degree in computer science, engineering, or related field. Strong programming skills and experience with automation tools like Selenium or QTP are required. Understanding of software development methodologies and experience with CI/CD tools are beneficial.", "Responsibilities include designing and implementing automated testing frameworks, writing and executing test scripts, identifying and logging defects, and working with the development team to resolve them. Automation Testers also maintain and enhance test automation environments and integrate automation tests with the CI/CD pipeline." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Qualifications include a bachelor's degree in computer science or a related field, with a strong understanding of performance testing methodologies and tools (e.g., LoadRunner, JMeter). Knowledge of programming and scripting languages, and experience with system monitoring tools are important.", "Responsibilities involve planning, designing, and implementing performance tests to ensure software applications meet performance criteria. This includes analyzing test results, identifying bottlenecks, and working closely with developers to optimize performance." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Qualifications for a Quality Analyst include a bachelor's degree in computer science, IT, or a related field, with a deep understanding of QA methodologies. Strong analytical skills, attention to detail, and experience with QA tools and processes are essential.", "The main responsibilities include analyzing software products to ensure they meet quality standards and user requirements. This involves developing and executing test plans, documenting defects, and collaborating with development teams to resolve issues." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "A Data Scientist typically holds a master’s or Ph.D. in data science, statistics, computer science, or a related field. Essential skills include proficiency in programming languages like Python or R, experience with data visualization tools, and a strong foundation in machine learning and statistical analysis.", "Responsibilities include collecting, processing, and analyzing large data sets to identify trends and patterns. Data Scientists develop predictive models, algorithms, and conduct experiments to test their effectiveness. They also communicate findings to stakeholders and provide insights to inform decision-making." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Qualifications include a degree in computer science, mathematics, or a related technical field. Proficiency in programming languages such as Python or Java, and experience with machine learning frameworks (e.g., TensorFlow, PyTorch) are required. A strong mathematical background is also important.", "Machine Learning Engineers are responsible for designing and implementing machine learning models. They work on data preprocessing, model training, testing, and deployment. Collaborating with data scientists and software engineers to integrate models into production systems is also part of their role." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "A Data Analyst typically holds a bachelor's degree in information technology, computer science, or a related field. Proficiency in SQL, Excel, and data visualization tools like Tableau or Power BI is required. Analytical thinking and problem-solving skills are essential.", "Data Analysts collect and interpret data to identify trends, patterns, and insights. They create reports and dashboards for stakeholders, helping to drive decision-making and strategic planning. Ensuring data accuracy and providing recommendations based on data analysis are key responsibilities." });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Bachelor's degree in Computer Science or related field\nExperience with big data technologies\nStrong analytical skills", "Develop and manage big data solutions\nAnalyze data sets to identify insights\nEnsure data security and privacy" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Bachelor's degree in Marketing or related field\nExperience with digital marketing tools and platforms\nStrong communication and analytical skills", "Plan and execute digital marketing campaigns\nMonitor and analyze campaign performance\nCollaborate with other teams to integrate marketing strategies" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Proven experience as SEO Analyst\nKnowledge of SEO practices and analytics tools\nExcellent communication skills", "Perform ongoing keyword research\nOptimize website content for search engines\nTrack and analyze website analytics" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Experience with social media management\nStrong communication and creative skills\nAbility to analyze performance metrics", "Develop and implement social media strategy\nCreate and distribute engaging content\nMonitor and report on performance metrics" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Proven content creation experience\nExcellent writing and editing skills\nUnderstanding of marketing strategies", "Develop content strategy aligned with marketing targets\nCreate and publish engaging content\nAnalyze content performance and adjust strategies as needed" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Bachelor's degree in Graphic Design or related field\nProficiency in graphic design software\nCreative thinking and attention to detail", "Create visual aspects of marketing materials, websites, and other media\nWork with clients or the art director to determine the scope of a project\nUse digital illustration, photo editing software, and layout software to create designs" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Strong portfolio of illustrations or other graphics\nFamiliarity with design software and technologies\nA keen eye for aesthetics and details", "Create original pieces of artwork for digital or print\nUse various colors, graphics and effects to better visualize each concept\nParticipate in design briefs with clients, editors, or marketers to identify their needs" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Proven experience as an Art Director\nStrong portfolio showcasing high-end digital design skills\nAbility to think creatively and provide marketable solutions", "Determine the best way to represent a concept visually\nDecide which photographs, art, or other design elements to use\nDevelop the overall look or style of a publication, an advertising campaign, or a theater, television, or film set" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Demonstrable graphic design skills with a strong portfolio\nProficiency with required desktop publishing tools, including Photoshop, After Effects, and Adobe Animate\nA strong eye for visual composition", "Design and create enticing motion graphics for video deliverables (corporate videos, websites, marketing demos, etc.)\nPrepare design plan, concept, and layout for motion graphic project\nAssist in selecting audio, video, colors, animation, etc. for graphic design" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Bachelor's degree in Finance, Accounting, or related field\nExperience with financial modeling and statistical analysis\nStrong analytical and data gathering skills", "Analyze financial data to identify trends and make recommendations\nPrepare financial reports and forecasts\nEvaluate investment opportunities and provide recommendations" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Bachelor's degree in Finance, Economics, or related field\nStrong analytical and quantitative skills\nExcellent communication and interpersonal skills", "Advise clients on investment opportunities and strategies\nManage and structure financial deals\nConduct financial analysis and market research" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Bachelor's degree in Finance, Economics, or a related field\nCertification as a Certified Financial Planner (CFP) preferred\nStrong understanding of the financial market and investment strategies", "Assess clients' financial situations and understand their needs\nProvide personalized financial advice and investment solutions\nMonitor and review clients' accounts and adjust plans as necessary" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Bachelor's degree in Accounting or related field\nCertification (e.g., CPA) is a plus\nProven experience as an accountant", "Prepare accurate financial statements and reports\nEnsure compliance with financial laws and regulations\nManage all accounting transactions and audit financial transactions and documents" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateTime", "Location", "Qualifications", "Responsibility", "Salary" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assiut", "Bachelor of Science in Nursing (BSN) degree\nActive Registered Nurse license\nProven experience as a registered nurse", "Provide direct patient care and assess their conditions\nAdminister medications and treatments\nEducate patients and their families on health plans and preventive care", 29200.0 });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Medical degree from a recognized university\nValid license to practice the profession\nProven experience as a Medical Doctor", "Diagnose patient conditions using examinations and tests\nPrescribe and administer treatment\nAdvise patients on health and preventive care" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Proven experience as a medical assistant or in a similar role\nKnowledge of healthcare operations and medical terminology\nStrong organizational and communication skills", "Assist in examining and treating patients under the direction of a physician\nPrepare patients for examinations and perform routine diagnostic checks\nManage medical supplies and keep detailed records of all patient interactions" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { "Degree in Pharmacy or Pharmacology\nValid pharmacist license\nProven experience as a pharmacist", "Dispense medications accurately and ensure safety and quality standards are met\nProvide information to patients about medications and their use\nManage inventory and perform administrative tasks" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Qualifications", "Responsibility" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qualifications",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Responsibility",
                table: "Jobs");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: "Cario");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateTime", "Location", "Salary" },
                values: new object[] { null, null, 0.0 });
        }
    }
}
