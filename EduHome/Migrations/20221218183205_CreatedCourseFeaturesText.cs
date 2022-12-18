using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class CreatedCourseFeaturesText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutDesc",
                table: "Courses",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplyDesc",
                table: "Courses",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CertificationDesc",
                table: "Courses",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseAssesments",
                table: "Courses",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseClassDuration",
                table: "Courses",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseDuration",
                table: "Courses",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseLanguage",
                table: "Courses",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseSkillLevel",
                table: "Courses",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CourseStarts",
                table: "Courses",
                maxLength: 255,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CourseStudents",
                table: "Courses",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FEE",
                table: "Courses",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastDesc",
                table: "Courses",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleDesc",
                table: "Courses",
                maxLength: 1000,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutDesc",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ApplyDesc",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CertificationDesc",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseAssesments",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseClassDuration",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseDuration",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseLanguage",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseSkillLevel",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseStarts",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseStudents",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "FEE",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LastDesc",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TitleDesc",
                table: "Courses");
        }
    }
}
