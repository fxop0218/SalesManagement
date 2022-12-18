using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesManagment.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "CPU" },
                    { 2, "GPU" },
                    { 3, "Mobiles" },
                    { 4, "Computers" },
                    { 5, "RAM" },
                    { 6, "SSD" },
                    { 7, "motherboard" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgPath", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/13600k.jpg", "i5 13600K", 200m },
                    { 2, 1, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/13700k.jpg", "I7-13700K ", 210m },
                    { 3, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/rtx2080.jpg", "RTX 2080 FE", 500m },
                    { 4, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/rtx3080.jpg", "RTX 3080 FE", 800m },
                    { 5, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/rtx4080.jpg", "RTX 4080 FE", 252m },
                    { 6, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/rtx4090.jpg", "RTX 4090 FE", 2000m },
                    { 7, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/pf1.jpg", "POCO F1", 230m },
                    { 8, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/s22.jpg", "Samsung s22", 600m },
                    { 9, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/IPhone13.jpg", "IPhone13", 1000m },
                    { 10, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/IPhone14.jpg", "IPhone14", 1600m },
                    { 11, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/IPhone14Pro.jpg", "IPhone14 PRO", 2000m },
                    { 12, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/IPhone14ProMax.jpg", "IPhone14 ProMax", 4000m },
                    { 13, 4, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/MacBook.jpg", "MacBook", 2000m },
                    { 14, 4, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Razer.jpg", "Razer", 1500m },
                    { 15, 4, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/Surface.jpg", "Surface", 1200m },
                    { 16, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/ram.jpg", "RAM 8gb", 60m },
                    { 17, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/ram.jpg", "RAM 16gb", 100m },
                    { 18, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/ram.jpg", "RAM 32gb", 200m },
                    { 19, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/ram.jpg", "RAM 64gb", 300m },
                    { 20, 6, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/ssd1t.jpg", "SSD 1Tb", 100m },
                    { 21, 6, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/m2tb.jpg", "SSD m.2 2Tb", 200m },
                    { 22, 6, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/m2tb.jpg", "SSD m.2 5Tb", 400m },
                    { 23, 7, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/mb1.jpg", "MB 1", 200m },
                    { 24, 7, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/Products/mb1.jpg", "MB 2", 400m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
