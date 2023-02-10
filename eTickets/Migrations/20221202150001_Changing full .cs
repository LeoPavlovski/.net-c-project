using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class Changingfull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_cinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_producerId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_producerId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "profilePictureUrl",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "bio",
                table: "Producers",
                newName: "Bio");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Movies",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "producerId",
                table: "Movies",
                newName: "ProducerId");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Movies",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Movies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "movieCategory",
                table: "Movies",
                newName: "MovieCategory");

            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "Movies",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Movies",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "cinemaId",
                table: "Movies",
                newName: "CinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_cinemaId",
                table: "Movies",
                newName: "IX_Movies_CinemaId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Cinemas",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "logo",
                table: "Cinemas",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Cinemas",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "profilePictureUrl",
                table: "Actors",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "Actors",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "bio",
                table: "Actors",
                newName: "Bio");

            migrationBuilder.AddColumn<int>(
                name: "CinemaID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProducerID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerID",
                table: "Movies",
                column: "ProducerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerID",
                table: "Movies",
                column: "ProducerID",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ProducerID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CinemaID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ProducerID",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "profilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "Producers",
                newName: "bio");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Movies",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Movies",
                newName: "producerId");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Movies",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Movies",
                newName: "movieCategory");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Movies",
                newName: "imageUrl");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Movies",
                newName: "endDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CinemaId",
                table: "Movies",
                newName: "cinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                newName: "IX_Movies_cinemaId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cinemas",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Cinemas",
                newName: "logo");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "profilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "Actors",
                newName: "bio");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_producerId",
                table: "Movies",
                column: "producerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_cinemaId",
                table: "Movies",
                column: "cinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_producerId",
                table: "Movies",
                column: "producerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
