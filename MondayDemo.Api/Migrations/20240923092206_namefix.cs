using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MondayDemo.Api.Migrations
{
    /// <inheritdoc />
    public partial class namefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "Chores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chores",
                table: "Chores",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Chores",
                table: "Chores");

            migrationBuilder.RenameTable(
                name: "Chores",
                newName: "MyProperty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");
        }
    }
}
