using Microsoft.EntityFrameworkCore.Migrations;

namespace UserRoles.Migrations
{
    public partial class AddimagecolintblUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "tblUsers",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "tblUsers");
        }
    }
}
