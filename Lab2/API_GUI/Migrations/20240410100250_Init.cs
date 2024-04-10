using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_GUI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", false),
                    name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    species = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    gender = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    origin = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    location = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    image = table.Column<string>(type: "TEXT", nullable: false),
                    episode = table.Column<string>(type: "TEXT", nullable: false),
                    url = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Character");
        }
    }
}
