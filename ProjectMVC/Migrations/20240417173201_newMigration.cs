using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMVC.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplyForJobs_AspNetUsers_UserId",
                table: "ApplyForJobs");

            migrationBuilder.DropIndex(
                name: "IX_ApplyForJobs_UserId",
                table: "ApplyForJobs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ApplyForJobs");

            migrationBuilder.AddColumn<string>(
                name: "portfolio",
                table: "ApplyForJobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userEmail",
                table: "ApplyForJobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "ApplyForJobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "portfolio",
                table: "ApplyForJobs");

            migrationBuilder.DropColumn(
                name: "userEmail",
                table: "ApplyForJobs");

            migrationBuilder.DropColumn(
                name: "userName",
                table: "ApplyForJobs");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ApplyForJobs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ApplyForJobs_UserId",
                table: "ApplyForJobs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplyForJobs_AspNetUsers_UserId",
                table: "ApplyForJobs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
