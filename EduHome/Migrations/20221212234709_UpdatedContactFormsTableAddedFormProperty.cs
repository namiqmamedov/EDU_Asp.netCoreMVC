using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedContactFormsTableAddedFormProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FormEmail",
                table: "ContactForms",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormMessage",
                table: "ContactForms",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormName",
                table: "ContactForms",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormSubject",
                table: "ContactForms",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormEmail",
                table: "ContactForms");

            migrationBuilder.DropColumn(
                name: "FormMessage",
                table: "ContactForms");

            migrationBuilder.DropColumn(
                name: "FormName",
                table: "ContactForms");

            migrationBuilder.DropColumn(
                name: "FormSubject",
                table: "ContactForms");
        }
    }
}
