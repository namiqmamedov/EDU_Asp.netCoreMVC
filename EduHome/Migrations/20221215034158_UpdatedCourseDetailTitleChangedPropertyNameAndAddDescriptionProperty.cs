using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedCourseDetailTitleChangedPropertyNameAndAddDescriptionProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetailTitles_DetailTitles_DetailTitleId",
                table: "CourseDetailTitles");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "CourseDetailTitles");

            migrationBuilder.AlterColumn<int>(
                name: "DetailTitleId",
                table: "CourseDetailTitles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CourseDetailTitles",
                maxLength: 855,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetailTitles_DetailTitles_DetailTitleId",
                table: "CourseDetailTitles",
                column: "DetailTitleId",
                principalTable: "DetailTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetailTitles_DetailTitles_DetailTitleId",
                table: "CourseDetailTitles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CourseDetailTitles");

            migrationBuilder.AlterColumn<int>(
                name: "DetailTitleId",
                table: "CourseDetailTitles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "CourseDetailTitles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetailTitles_DetailTitles_DetailTitleId",
                table: "CourseDetailTitles",
                column: "DetailTitleId",
                principalTable: "DetailTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
