using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MySiteMVC.Migrations
{
    public partial class AddExperienceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "Project",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Organization = table.Column<string>(nullable: false),
                    OrgLogo = table.Column<string>(nullable: true),
                    JobTitle = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.ExperienceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ExperienceId",
                table: "Project",
                column: "ExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Experience_ExperienceId",
                table: "Project",
                column: "ExperienceId",
                principalTable: "Experience",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Experience_ExperienceId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropIndex(
                name: "IX_Project_ExperienceId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Project");
        }
    }
}
