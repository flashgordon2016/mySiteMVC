using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MySiteMVC.Migrations
{
    public partial class AddedTermTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TermTypeId",
                table: "Education",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TermTypes",
                columns: table => new
                {
                    TermTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Term = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermTypes", x => x.TermTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Education_TermTypeId",
                table: "Education",
                column: "TermTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_TermTypes_TermTypeId",
                table: "Education",
                column: "TermTypeId",
                principalTable: "TermTypes",
                principalColumn: "TermTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_TermTypes_TermTypeId",
                table: "Education");

            migrationBuilder.DropTable(
                name: "TermTypes");

            migrationBuilder.DropIndex(
                name: "IX_Education_TermTypeId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "TermTypeId",
                table: "Education");
        }
    }
}
