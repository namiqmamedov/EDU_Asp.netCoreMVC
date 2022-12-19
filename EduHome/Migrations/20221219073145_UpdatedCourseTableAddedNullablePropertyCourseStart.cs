using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedCourseTableAddedNullablePropertyCourseStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CourseStarts",
                table: "Courses",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 255);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CourseStarts",
                table: "Courses",
                type: "datetime2",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
