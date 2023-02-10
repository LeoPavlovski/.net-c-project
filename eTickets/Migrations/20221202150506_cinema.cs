using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class cinema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaID",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "CinemaID",
                table: "Movies",
                newName: "cinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CinemaID",
                table: "Movies",
                newName: "IX_Movies_cinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_cinemaId",
                table: "Movies",
                column: "cinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_cinemaId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "cinemaId",
                table: "Movies",
                newName: "CinemaID");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_cinemaId",
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
    }
}
