using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesManagment.Migrations
{
    /// <inheritdoc />
    public partial class correctOrderSyntax : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrederItems",
                table: "OrederItems");

            migrationBuilder.RenameTable(
                name: "OrederItems",
                newName: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "ClinetId",
                table: "Orders",
                newName: "ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrederItems");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Orders",
                newName: "ClinetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrederItems",
                table: "OrederItems",
                column: "Id");
        }
    }
}
