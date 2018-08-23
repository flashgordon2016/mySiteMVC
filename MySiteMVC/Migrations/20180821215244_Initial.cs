using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MySiteMVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.CreateTable(
                name: "Blog_Post",
                columns: table => new
                {
                    Blog_PostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Summary = table.Column<string>(nullable: false),
                    Original_Post_Date = table.Column<DateTime>(type: "date", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "date", nullable: false),
                    BannerImgPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog_Post", x => x.Blog_PostID);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagID);
                });

            migrationBuilder.CreateTable(
                name: "Post_Tags_Junction",
                columns: table => new
                {
                    TagID = table.Column<int>(nullable: false),
                    Blog_PostID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_Tags_Junction", x => new { x.TagID, x.Blog_PostID });
                    table.ForeignKey(
                        name: "FK_Blog_Post",
                        column: x => x.Blog_PostID,
                        principalTable: "Blog_Post",
                        principalColumn: "Blog_PostID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tag",
                        column: x => x.TagID,
                        principalTable: "Tag",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_Tags_Junction_Blog_PostID",
                table: "Post_Tags_Junction",
                column: "Blog_PostID");*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropTable(
                name: "Post_Tags_Junction");

            migrationBuilder.DropTable(
                name: "Blog_Post");

            migrationBuilder.DropTable(
                name: "Tag");*/
        }
    }
}
