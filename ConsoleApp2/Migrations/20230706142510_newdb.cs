using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backers_Projects_ProjectsId",
                table: "Backers");

            migrationBuilder.RenameColumn(
                name: "ProjectsId",
                table: "Backers",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Backers_ProjectsId",
                table: "Backers",
                newName: "IX_Backers_ProjectId");

            migrationBuilder.AddColumn<string>(
                name: "VideoDescription",
                table: "ProjectVideos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoDescription",
                table: "ProjectPhotos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Backers_Projects_ProjectId",
                table: "Backers",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backers_Projects_ProjectId",
                table: "Backers");

            migrationBuilder.DropColumn(
                name: "VideoDescription",
                table: "ProjectVideos");

            migrationBuilder.DropColumn(
                name: "PhotoDescription",
                table: "ProjectPhotos");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Backers",
                newName: "ProjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_Backers_ProjectId",
                table: "Backers",
                newName: "IX_Backers_ProjectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backers_Projects_ProjectsId",
                table: "Backers",
                column: "ProjectsId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
