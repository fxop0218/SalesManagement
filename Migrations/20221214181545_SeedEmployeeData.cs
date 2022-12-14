using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesManagment.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployeeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JobTitle",
                table: "Employees",
                newName: "Email");

            migrationBuilder.InsertData(
                table: "EmployeeJobTitles",
                columns: new[] { "EmployeeJobTitleId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Sales Manager", "SM" },
                    { 2, "Team Leader", "TL" },
                    { 3, "Sales Rep", "SR" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Email", "EmployeeTitleId", "FirstName", "Gender", "ImagePath", "ReportToEmpId", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(1974, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.jones@oexl.com", 1, "Bob", "Male", "/Images/Profile/BobJones.jpg", null, "Jones" },
                    { 2, new DateTime(1976, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "jenny.marks@oexl.com", 2, "Jenny", "Female", "/Images/Profile/JennyMarks.jpg", 1, "Marks" },
                    { 3, new DateTime(1981, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "henry.andrews@oexl.com", 2, "Henry", "Male", "/Images/Profile/HenryAndrews.jpg", 1, "Andrews" },
                    { 4, new DateTime(1984, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.jameson@oexl.com", 2, "John", "Male", "/Images/Profile/JohnJameson.jpg", 1, "Jameson" },
                    { 5, new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "noah.robinson@oexl.com", 3, "Noah", "Male", "/Images/Profile/NoahRobinson.jpg", 2, "Robinson" },
                    { 6, new DateTime(1993, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "elijah.hamilton@oexl.com", 3, "Elijah", "Male", "/Images/Profile/ElijahHamilton.jpg", 2, "Hamilton" },
                    { 7, new DateTime(1992, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamie.fisher@oexl.com", 3, "Jamie", "Male", "/Images/Profile/JamieFisher.jpg", 2, "Fisher" },
                    { 8, new DateTime(1990, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "olivia.mills@oexl.com", 3, "Olivia", "Female", "/Images/Profile/OliviaMills.jpg", 3, "Mills" },
                    { 9, new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "benjamin.lucas@oexl.com", 3, "Benjamin", "Male", "/Images/Profile/BenjaminLucas.jpg", 3, "Lucas" },
                    { 10, new DateTime(1993, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah.henderson@oexl.com", 3, "Sarah", "Female", "/Images/Profile/SarahHenderson.jpg", 3, "Henderson" },
                    { 11, new DateTime(1995, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma.lee@oexl.com", 3, "Emma", "Female", "/Images/Profile/EmmaLee.jpg", 4, "Lee" },
                    { 12, new DateTime(1998, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ava.williams@oexl.com", 3, "Ava", "Female", "/Images/Profile/AvaWilliams.jpg", 4, "Williams" },
                    { 13, new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "angela.moore@oexl.com", 3, "Angela", "Female", "/Images/Profile/AngelaMoore.jpg", 4, "Moore" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeJobTitles",
                keyColumn: "EmployeeJobTitleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeJobTitles",
                keyColumn: "EmployeeJobTitleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeJobTitles",
                keyColumn: "EmployeeJobTitleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Employees",
                newName: "JobTitle");
        }
    }
}
