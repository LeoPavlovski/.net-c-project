using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class newcinema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CinemaID",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "CinemaId",
                table: "Movies",
                newName: "CinemaID");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                newName: "IX_Movies_CinemaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaID",
                table: "Movies",
                column: "CinemaID",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaID",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "CinemaID",
                table: "Movies",
                newName: "CinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CinemaID",
                table: "Movies",
                newName: "IX_Movies_CinemaId");

            migrationBuilder.AddColumn<int>(
                name: "CinemaID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
