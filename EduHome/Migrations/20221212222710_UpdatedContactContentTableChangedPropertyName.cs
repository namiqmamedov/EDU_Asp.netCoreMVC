using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedContactContentTableChangedPropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddrDescription1",
                table: "ContactContents");

            migrationBuilder.DropColumn(
                name: "AddrDescription2",
                table: "ContactContents");

            migrationBuilder.DropColumn(
                name: "AddrDescription3",
                table: "ContactContents");

            migrationBuilder.DropColumn(
                name: "AddrDescription4",
                table: "ContactContents");

            migrationBuilder.DropColumn(
                name: "AddrDescription5",
                table: "ContactContents");

            migrationBuilder.DropColumn(
                name: "AddrDescription6",
                table: "ContactContents");

            migrationBuilder.DropColumn(
                name: "AddrTitle1",
                table: "ContactContents");

            migrationBuilder.DropColumn(
                name: "AddrTitle2",
                table: "ContactContents");

            migrationBuilder.DropColumn(
                name: "AddrTitle3",
                table: "ContactContents");

            migrationBuilder.AddColumn<string>(
                name: "MainDescription",
                table: "ContactContents",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubDescription",
                table: "ContactContents",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ContactContents",
                maxLength: 2500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainDescription",
                table: "ContactContents");

            migrationBuilder.DropColumn(
                name: "SubDescription",
                table: "ContactContents");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "ContactContents");

            migrationBuilder.AddColumn<string>(
                name: "AddrDescription1",
                table: "ContactContents",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddrDescription2",
                table: "ContactContents",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddrDescription3",
                table: "ContactContents",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddrDescription4",
                table: "ContactContents",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddrDescription5",
                table: "ContactContents",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddrDescription6",
                table: "ContactContents",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddrTitle1",
                table: "ContactContents",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddrTitle2",
                table: "ContactContents",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddrTitle3",
                table: "ContactContents",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);
        }
    }
}
