using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class seedClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Client_Id", "Address", "City", "Country", "Email", "FirstName", "LastName", "Phone", "State" },
                values: new object[,]
                {
                    { 1, "7 Carnarvon Crescent", "Stanhope Garden", "Australia", "Ashley.Martinez@financeteam.net", "Ashley ", "Martinez", "0412 345 678", "NSW" },
                    { 2, "24 Teakwood Drive", "Narre Warren South", "Australia", "John.Williams@moneyplus.com", "John", "Williams", "0432 123 456", "VIC" },
                    { 3, "29 Rofe Street", "Leichhardt", "Australia", "Jessica.Smith@finance.com", "Jessica", "Smith", "0421 987 654", "NSW" },
                    { 4, "14 Elsom Street", "South Windsor", "Australia", "Tyler.Johnson@investoradvisor.net", "Tyler", "Davis", "0456 789 012", "NSW" },
                    { 5, "5 View Road", "Springwood", "Australia", "Samantha.Davis@finance.com", "Samantha", "Brown", "0401 234 567", "QLD" },
                    { 6, "5 Norman Street", " Doncaster", "Australia", "David.Brown@moneywise.com.au", "David", "Rodriguez", "0437 456 789", "VIC" },
                    { 7, "16 Rydges Street", "South Wentworthville", "Australia", "Maria.Rodriguez@finance.com", "Maria", "Anderson", "0423 210 987", "NSW" },
                    { 8, "4 Bluebell Circuit", "Coffs Harbour", "Australia", "Kevin.Anderson@finance.com", "Kevin", "Wilson", "0445 678 901", "NSW" },
                    { 9, "21 Willow Crescent", " Footscray", "Australia", "Olivia.Wilson@finance.com", "Olivia", "Miller", "0409 876 543", "VIC" },
                    { 10, "25 Tiernan Street", "Mount Druitt", "Australia", "Michael.Miller@@financialadvice.net", "Michael", "Taylor", "0434 321 098", "VIC" },
                    { 11, "2/49 Acacia Street", "Mandurah", "Australia", "Sarah.Taylor@finance.com", "Sarah", "Thompson", "0415 678 901", "NSW" },
                    { 12, "1/23 Hollis Street", " Bonbeach", "Australia", "Christopher.Thompson@finance.com", "Christopher", "Jackson", "0426 543 210", "WA" },
                    { 13, "15 Giselle Avenue", "Mosman", "Australia", "Emily.Jackson@moneycoach.com", "Joshua", "Lewis", "0450 987 654", "VIC" },
                    { 14, "2/6 Belmont Road", "Buddina", "Australia", "Joshua.Lewis@finance.com", "Elizabeth", "Clark", "0407 321 098", "NSW" },
                    { 15, "34 Orana Parade", "Penrith", "Australia", "Elizabeth.Clark@finance.com", "Daniel", "Lee", "0439 876 543", "NSW" },
                    { 16, "9 Carey Street", " Bossley Park", "Australia", "Daniel.Lee@@financetoday.net", "Taylor", "Hall", "0418 765 432", "NSW" },
                    { 17, "42 Mimosa Road", "Smithfield", "Australia", "Taylor.Hall@finance.com", "Matthew", "Wright", "0429 012 345", "NSW" },
                    { 18, "27 Pirrama Road", "Ocean Grove", "Australia", "Matthew.Wright@finance.com", "Madison", "Scott", "0441 234 567", "QLD" },
                    { 19, "14 Long Street", "Pakenham", "Australia", "Madison.Scott@finance.com", "Andrew", "Perez", "0405 876 543", "VIC" },
                    { 20, "3/25 Lake Avenue", "Laverton", "Australia", "Andrew.Perez@yourfinancials.com", "Alyssa", "Cooper", "0430 210 987", "VIC" },
                    { 21, "1/12 Station Street", "Rothwell", "Australia", "Alyssa.Cooper@finance.com", "Robert", "Baker", "0413 456 789", "VIC" },
                    { 22, "13 Neville Avenue", "Carlton", "Australia", "Robert.Baker@moneymentor.net", "Lauren", "Turner", "0424 321 098", "QLD" },
                    { 23, "16 Vaucluse Place", "Coorparoo", "Australia", "Lauren.Turner@finance.com", "William", "Gonzalez", "0453 654 321", "VIC" },
                    { 24, "4/1 Hampton Court Road", "Thornleigh", "Australia", "William.Gonzalez@financialadvice.net", "Rachel", "Adams", "0408 765 432", "QLD" },
                    { 25, "1/2 Marday Street", "Padbury", "Australia", "Rachel.Adams@finance.com", "James ", "Wright", "0436 012 345", "NSW" },
                    { 26, "46 Holt Parade", "Geelong West", "Australia", "James.Wright@wealthbuilder.net", "Victoria", "Nelson", "0417 654 321", "WA" },
                    { 27, "23 Howard Road", "Burleigh Waters", "Australia", "Victoria.Nelson@yourwealth.com", "Benjamin", "Johnson", "0428 901 234", "VIC" },
                    { 28, "9 Panorama Avenue", "Anytown", "Australia", "Benjamin.Flores@moneyplan.net", "Grace", "Flores", "0440 543 210", "QLD" },
                    { 29, "10 Dolly Avenue", "Clontarf", "Australia", "Grace.Mitchell@finance.com", "Jane", "Mitchell", "0406 789 012", "QLD" },
                    { 30, "8 O'Grady Street", "Coorparoo", "Australia", "Nicholas.Collins@finance.com", "Nicholas", "Collins", "0431 234 567", "QLD" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Client_Id",
                keyValue: 30);
        }
    }
}
