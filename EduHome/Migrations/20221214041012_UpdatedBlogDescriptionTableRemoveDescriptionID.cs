using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedBlogDescriptionTableRemoveDescriptionID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogDescriptions_Descriptions_DescriptionId",
                table: "BlogDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_BlogDescriptions_DescriptionId",
                table: "BlogDescriptions");

            migrationBuilder.DropColumn(
                name: "QuoraDescription",
                table: "Descriptions");

            migrationBuilder.DropColumn(
                name: "SimpleDescription",
                table: "Descriptions");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "BlogDescriptions");

            migrationBuilder.AddColumn<string>(
                name: "QuoteDescription",
                table: "BlogDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SimpleDescription",
                table: "BlogDescriptions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteDescription",
                table: "BlogDescriptions");

            migrationBuilder.DropColumn(
                name: "SimpleDescription",
                table: "BlogDescriptions");

            migrationBuilder.AddColumn<string>(
                name: "QuoraDescription",
                table: "Descriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SimpleDescription",
                table: "Descriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "BlogDescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BlogDescriptions_DescriptionId",
                table: "BlogDescriptions",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogDescriptions_Descriptions_DescriptionId",
                table: "BlogDescriptions",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
