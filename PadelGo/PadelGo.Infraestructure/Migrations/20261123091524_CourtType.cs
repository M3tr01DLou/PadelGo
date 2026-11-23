using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PadelGo.Infraestructure.Migrations;

/// <inheritdoc />
public partial class _20261123091524_CourtType : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "CourtTypes",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                Active = table.Column<bool>(type: "bit", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_CourtTypes", x => x.Id);
            });

        migrationBuilder.CreateIndex(
            name: "IX_CourtTypes_Type",
            table: "CourtTypes",
            column: "Type",
            unique: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "CourtTypes");
    }
}
