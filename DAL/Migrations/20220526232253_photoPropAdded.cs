using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class photoPropAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Users",
                newName: "Photo");

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Users",
                newName: "Picture");
        }
    }
}
