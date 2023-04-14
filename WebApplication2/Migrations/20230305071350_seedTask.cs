using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class seedTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Task_Id", "Description", "EndDate", "Name", "Project_Id", "StartDate", "Status", "TimeEstimate", "User_Id" },
                values: new object[,]
                {
                    { 150, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Financial Analysis ", 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress", 4.0, 102 },
                    { 151, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developing Business Plan ", 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned", 4.0, null },
                    { 152, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Tax Compliance Audit", 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete", 4.0, 102 },
                    { 153, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developing Risk Assessment Strategy ", 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress", 4.0, 106 },
                    { 154, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Budget Planning", 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress", 4.0, 115 },
                    { 155, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Market Research ", 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned", 4.0, null },
                    { 156, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Managing Investment Portfolio", 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned", 4.0, null },
                    { 157, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Implementing Accounting System ", 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned", 4.0, null },
                    { 158, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Optimizing Costs", 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete", 4.0, 125 },
                    { 159, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developing Corporate Social Responsibility Program", 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete", 4.0, 119 },
                    { 160, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Performing Financial Statement Analysis ", 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress", 4.0, 122 },
                    { 161, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Competitive Analysis", 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned", 4.0, null },
                    { 162, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Managing Accounts Payable", 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress", 4.0, 112 },
                    { 163, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Sales Forecasting ", 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned", 4.0, null },
                    { 164, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developing Performance Metrics", 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress", 4.0, 122 },
                    { 165, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developing Cost Reduction Strategies", 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress", 4.0, 122 },
                    { 166, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Compliance Audits ", 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete", 4.0, 123 },
                    { 167, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creating Strategic Plans ", 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned", 4.0, null },
                    { 168, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Industry Analysis", 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete ", 4.0, 110 },
                    { 169, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Investment Analysis", 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress", 4.0, 101 },
                    { 170, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Financial Due Diligence", 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " InProgress", 4.0, 101 },
                    { 171, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Environmental Impact Assessment ", 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress", 4.0, 101 },
                    { 172, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Implementing Internal Controls", 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned ", 4.0, null },
                    { 173, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developing Growth Strategies", 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned", 4.0, null },
                    { 174, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Risk Assessments", 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Unassigned", 4.0, null },
                    { 175, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developing Marketing Plans", 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete", 4.0, 122 },
                    { 176, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Vendor Analysis ", 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress", 4.0, 121 },
                    { 177, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Financial Modeling ", 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete", 4.0, 126 },
                    { 178, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conducting Employee Training Programs", 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned", 4.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 100,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 101,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 102,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 103,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 104,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 105,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 106,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 107,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 108,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 109,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 110,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 111,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 112,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 113,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 114,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 115,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 116,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 117,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 118,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 119,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 120,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 121,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 122,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 123,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 124,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 125,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 126,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 127,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 128,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 129,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 50, 403, DateTimeKind.Local).AddTicks(5745));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Task_Id",
                keyValue: 178);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 100,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 101,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 102,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 103,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 104,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 105,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 106,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 107,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 108,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 109,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 110,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 111,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 112,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 113,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 114,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 115,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 116,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 117,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 118,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 119,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 120,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 121,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 122,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 123,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 124,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 125,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 126,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 127,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 128,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 129,
                column: "Registration_date",
                value: new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7335));
        }
    }
}
