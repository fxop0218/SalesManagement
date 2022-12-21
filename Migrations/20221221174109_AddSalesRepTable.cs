using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesManagment.Migrations
{
    /// <inheritdoc />
    public partial class AddSalesRepTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesOrderReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderQty = table.Column<int>(type: "int", nullable: false),
                    OrderItemId = table.Column<int>(type: "int", nullable: false),
                    OrderItemQty = table.Column<int>(type: "int", nullable: false),
                    OrderItemPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ClientFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RetailOutletId = table.Column<int>(type: "int", nullable: false),
                    RetailOutletLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderReports", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesOrderReports");
        }
    }
}
