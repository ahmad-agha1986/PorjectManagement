using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class seedProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Project_Id", "Client_Id", "DueDate", "Name", "Status" },
                values: new object[,]
                {
                    { 50, 1, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analysis Report", "On going" },
                    { 51, 2, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), " Business Plan Development", "On going" },
                    { 52, 4, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), " Tax Compliance Audit", "On going" },
                    { 53, 4, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Risk Assessment Strategy", "On going" },
                    { 54, 5, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Budget Planning and Analysis", "On going" },
                    { 55, 6, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Market Research and Analysis", "On going" },
                    { 56, 7, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Investment Portfolio Management", "On going" },
                    { 57, 8, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accounting System Implementation", "On going" },
                    { 58, 8, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cost Optimization Initiative", "On going" },
                    { 59, 10, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corporate Social Responsibility ", "On going" },
                    { 60, 10, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analysis Report", "On going" },
                    { 61, 12, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Market Research and Analysis", "On going" },
                    { 62, 15, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), " Accounting System Implementation", "On going" },
                    { 63, 14, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business Plan Development", "On going" },
                    { 64, 15, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corporate Social Responsibility Program", "On going" },
                    { 65, 16, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cost Optimization Initiative", "On going" },
                    { 66, 17, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tax Compliance Audit", "On going" },
                    { 67, 18, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Risk Assessment Strategy", "On going" },
                    { 68, 19, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Market Research and Analysis", "On going" },
                    { 69, 20, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Investment Portfolio Management", "On going" },
                    { 70, 20, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analysis Report", "On going" },
                    { 71, 20, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), " Corporate Social Responsibility Program", "On going" },
                    { 72, 23, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accounting System Implementation", "On going" },
                    { 73, 24, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business Plan Development", "On going" },
                    { 74, 25, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Risk Assessment Strategy", "On going" },
                    { 75, 26, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Market Research and Analysis", "On going" },
                    { 76, 22, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cost Optimization Initiative", "On going" },
                    { 77, 28, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analysis Report", "On going" },
                    { 78, 29, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), " Corporate Social Responsibility Program", "On going" },
                    { 79, 28, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Risk Assessment Strategy", "On going" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Project_Id",
                keyValue: 79);
        }
    }
}
