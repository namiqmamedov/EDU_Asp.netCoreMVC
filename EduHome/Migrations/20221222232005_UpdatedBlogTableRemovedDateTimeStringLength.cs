using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedBlogTableRemovedDateTimeStringLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
               name: "Date",
               table: "Blogs",
               nullable: true,
               oldClrType: typeof(string),
               oldType: "nvarchar(45)",
               oldMaxLength: 45,
               oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
               name: "Date",
               table: "Blogs",
               type: "nvarchar(45)",
               maxLength: 45,
               nullable: true,
               oldClrType: typeof(string),
               oldNullable: true);
        }
    }
}
