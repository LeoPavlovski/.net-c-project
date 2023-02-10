using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class namechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movies_cinema_producerId",
                table: "movies");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_producer_producerId1",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producer",
                table: "producer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cinema",
                table: "cinema");

            migrationBuilder.RenameTable(
                name: "producer",
                newName: "producers");

            migrationBuilder.RenameTable(
                name: "cinema",
                newName: "cinemas");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producers",
                table: "producers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cinemas",
                table: "cinemas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_cinemas_producerId",
                table: "movies",
                column: "producerId",
                principalTable: "cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movies_producers_producerId1",
                table: "movies",
                column: "producerId1",
                principalTable: "producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movies_cinemas_producerId",
                table: "movies");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_producers_producerId1",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producers",
                table: "producers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cinemas",
                table: "cinemas");

            migrationBuilder.DropColumn(
                name: "description",
                table: "movies");

            migrationBuilder.RenameTable(
                name: "producers",
                newName: "producer");

            migrationBuilder.RenameTable(
                name: "cinemas",
                newName: "cinema");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producer",
                table: "producer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cinema",
                table: "cinema",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_cinema_producerId",
                table: "movies",
                column: "producerId",
                principalTable: "cinema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movies_producer_producerId1",
                table: "movies",
                column: "producerId1",
                principalTable: "producer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
