using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedEventDescriptionTableDropQuoteDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteDescription",
                table: "EventDescriptions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuoteDescription",
                table: "EventDescriptions",
                type: "nvarchar(855)",
                maxLength: 855,
                nullable: true);
        }
    }
}
