using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesManagment.Migrations
{
    /// <inheritdoc />
    public partial class correctdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDataTime",
                table: "Orders",
                newName: "OrderDateTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDateTime",
                table: "Orders",
                newName: "OrderDataTime");
        }
    }
}
