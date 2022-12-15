using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedTeacherHobbyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherHobbies");

            migrationBuilder.AddColumn<int>(
                name: "HobbyId",
                table: "Teachers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_HobbyId",
                table: "Teachers",
                column: "HobbyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Hobbies_HobbyId",
                table: "Teachers",
                column: "HobbyId",
                principalTable: "Hobbies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Hobbies_HobbyId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_HobbyId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "HobbyId",
                table: "Teachers");

            migrationBuilder.CreateTable(
                name: "TeacherHobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HobbyId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherHobbies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherHobbies_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherHobbies_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherHobbies_HobbyId",
                table: "TeacherHobbies",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherHobbies_TeacherId",
                table: "TeacherHobbies",
                column: "TeacherId");
        }
    }
}
