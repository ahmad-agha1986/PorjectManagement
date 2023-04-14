using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class changeUsertoUserAuthId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserAuths_UserId",
                table: "UserRoles");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserRoles",
                newName: "UserAuthId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                newName: "IX_UserRoles_UserAuthId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserAuths_UserAuthId",
                table: "UserRoles",
                column: "UserAuthId",
                principalTable: "UserAuths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserAuths_UserAuthId",
                table: "UserRoles");

            migrationBuilder.RenameColumn(
                name: "UserAuthId",
                table: "UserRoles",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserAuthId",
                table: "UserRoles",
                newName: "IX_UserRoles_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserAuths_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "UserAuths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
