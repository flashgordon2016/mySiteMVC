using Microsoft.EntityFrameworkCore.Migrations;

namespace MySiteMVC.Migrations
{
    public partial class AddPostImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannerImgPath",
                table: "Blog_Post",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerImgPath",
                table: "Blog_Post");
        }
    }
}
