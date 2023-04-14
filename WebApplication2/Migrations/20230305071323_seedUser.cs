using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class seedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_Id", "Email", "FirstName", "Job_Title", "LastName", "OnLeave", "Password", "Phone", "Registration_date", "Role" },
                values: new object[,]
                {
                    { 100, "johndoe@admin.com", "John", "Resource Manager ", "Doe", false, "Password123", "0422 123 456", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7265), "Admin" },
                    { 101, "alicesmith@financeteam.com", "Alice", "Financial Analyst ", "Smith", false, "Summer2023", "0413 456 789", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7285), "User" },
                    { 102, "danieljohnson@financeteam.com", "Daniel ", "Investment Banker ", "Johnson", false, "Pineapple21", "0438 987 654", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7287), "User" },
                    { 103, "evaortiz@financeteam.com", "Eva", "Risk Manager ", "Ortiz", true, "BlueBird20", "0488 765 432", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7289), "User" },
                    { 104, "mikewang@financeteam.com", "Mike", "Accountant ", "Wang", false, "LovelyDay22", "0400 555 666", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7291), "User" },
                    { 105, "chrisbrown@financeteam.com", "Chris", "Financial Planner ", "Brown", false, "Happy2023!", "0456 888 777", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7293), "User" },
                    { 106, "sarafoster@financeteam.com", "Sara", "Credit Analyst ", "Foster", false, "Secret123", "0499 222 111", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7295), "User" },
                    { 107, "mattdavis@financeteam.com", "Matt", "Treasury Analyst ", "Davis", true, "CoolCat21", "0424 333 222", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7297), "User" },
                    { 108, "lucychen@financeteam.com", "Lucy", "Asset Manager ", "Chen", false, "GoldenSun22", "0432 111 333", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7299), "User" },
                    { 109, "tomcoleman@financeteam.com", "Tom", "Compliance Officer ", "Coleman", false, "StarrySky20", "0444 888 222", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7300), "User" },
                    { 110, "amykim@financeteam.com", "Amy", "Actuary ", "Kim", false, "RedRose2023", "0465 222 333", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7302), "User" },
                    { 111, "johnpowell@financeteam.com", "John", "Tax Advisor ", "Powell", true, "Mountain21", "0477 333 111", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7304), "User" },
                    { 112, "jessicahoward@financeteam.com", "Jessica", "Auditor  ", "Howard", false, "CrazyBird22", "0405 444 555", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7305), "User" },
                    { 113, "gabrielholland@financeteam.com", "Gabriel", "Controller ", "Holland", false, "OceanView23", "0411 666 555", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7307), "User" },
                    { 114, "daviscox@financeteam.com", "Davis", "Portfolio Manager ", "Cox", true, "BrightSun20", "0455 777 444", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7309), "User" },
                    { 115, "ashleysimpson@financeteam.com", "Ashley", "Wealth Manager  ", "Simpson", false, "Dancing21!", "0423 888 333", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7311), "User" },
                    { 116, "chris.brown@financeteam.com", "Christophe", "Insurance Underwriter", "Brown", false, "Peaceful22", "0409 555 777", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7313), "User" },
                    { 117, "sara.lee@financeteam.com", "Sara", "Budget Analyst  ", "Lee", false, "SunnyDay23", "0467 777 444", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7315), "User" },
                    { 118, "lily.larson@financeteam.com", "Lily", "Corporate Finance Manager", "Larson", true, "Joyful21", "0498 444 888", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7316), "User" },
                    { 119, "isaac.chen@financeteam.com", "Isaac ", "Financial Consultant ", "Chen", false, "SilverMoon20", "0426 555 666", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7318), "User" },
                    { 120, "elijah.rivera@financeteam.com", "Elijah", "Loan Officer ", "Rivera", false, "LuckyDay22", "0435 666 888", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7320), "User" },
                    { 121, "julian.kim@financeteam.com", "Julian", "Financial Advisor ", "Kim", true, "PurpleRain23", "0472 333 555", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7321), "User" },
                    { 122, "john.murphy@financeteam.com", "John", "Data Analyst ", "Murphy", false, "WildFlower21", "0431 777 666", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7323), "User" },
                    { 123, "adrian.webb@financeteam.com", "Adrian ", "Procurement Specialist ", "Webb", false, "HappyHour20!", "0480 888 777", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7324), "User" },
                    { 124, "bob.sanders@financeteam.com", "Bob", " Financial Advisor", "Sanders", false, "Morning22", "0407 555 222", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7326), "User" },
                    { 125, "eva.ross@financeteam.com", "Eva", " Supply Chain Manager", "Ross", true, "OceanBreeze23", "0461 777 888", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7328), "User" },
                    { 126, "mike.wang@financeteam.comm", "Mike", " Investment Banker", "Wang", false, "Chocolate21", "0434 555 777", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7330), "User" },
                    { 127, "chris.brown@financeteam.com", "Chris", "Management Consultant ", "Brown", false, "GreenTree22", "0429 666 111", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7331), "User" },
                    { 128, "sara.sanchez@financeteam.com", "Sara", " Sales Manager", "Sanchez", false, "SnowyDay20", "0452 888 666", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7333), "User" },
                    { 129, "mia.bryant@financeteam.com", "Mia ", "Business Developer", "Bryant", true, "Diamond2023", "0479 555 444", new DateTime(2023, 3, 5, 18, 13, 23, 213, DateTimeKind.Local).AddTicks(7335), "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 129);
        }
    }
}
