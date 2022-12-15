using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdatedTeacherTableChangeRelationOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Hobbies_HobbyId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_HobbyId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "HobbyId",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "Hobby",
                table: "Teachers",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hobby",
                table: "Teachers");

            migrationBuilder.AddColumn<int>(
                name: "HobbyId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

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
    }
}
