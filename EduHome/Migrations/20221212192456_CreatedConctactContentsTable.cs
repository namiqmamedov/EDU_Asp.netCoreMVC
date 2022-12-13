using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class CreatedConctactContentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    AddrTitle1 = table.Column<string>(maxLength: 2500, nullable: true),
                    AddrDescription1 = table.Column<string>(maxLength: 2500, nullable: true),
                    AddrDescription2 = table.Column<string>(maxLength: 2500, nullable: true),
                    AddrTitle2 = table.Column<string>(maxLength: 2500, nullable: true),
                    AddrDescription3 = table.Column<string>(maxLength: 2500, nullable: true),
                    AddrDescription4 = table.Column<string>(maxLength: 2500, nullable: true),
                    AddrTitle3 = table.Column<string>(maxLength: 2500, nullable: true),
                    AddrDescription5 = table.Column<string>(maxLength: 2500, nullable: true),
                    AddrDescription6 = table.Column<string>(maxLength: 2500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactContents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactContents");
        }
    }
}
