using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class globalchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actor_movies_actors_actorId1",
                table: "actor_movies");

            migrationBuilder.DropForeignKey(
                name: "FK_actor_movies_movies_actorId",
                table: "actor_movies");

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
                name: "PK_movies",
                table: "movies");

            migrationBuilder.DropIndex(
                name: "IX_movies_producerId1",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cinemas",
                table: "cinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_actors",
                table: "actors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_actor_movies",
                table: "actor_movies");

            migrationBuilder.DropIndex(
                name: "IX_actor_movies_actorId1",
                table: "actor_movies");

            migrationBuilder.DropColumn(
                name: "producerId1",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "actorId1",
                table: "actor_movies");

            migrationBuilder.RenameTable(
                name: "producers",
                newName: "Producers");

            migrationBuilder.RenameTable(
                name: "movies",
                newName: "Movies");

            migrationBuilder.RenameTable(
                name: "cinemas",
                newName: "Cinemas");

            migrationBuilder.RenameTable(
                name: "actors",
                newName: "Actors");

            migrationBuilder.RenameTable(
                name: "actor_movies",
                newName: "Actors_Movies");

            migrationBuilder.RenameIndex(
                name: "IX_movies_producerId",
                table: "Movies",
                newName: "IX_Movies_producerId");

            migrationBuilder.RenameColumn(
                name: "movieId",
                table: "Actors_Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "actorId",
                table: "Actors_Movies",
                newName: "ActorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Producers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_cinemaId",
                table: "Movies",
                column: "cinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_cinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_producerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Producers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_cinemaId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.RenameTable(
                name: "Producers",
                newName: "producers");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "movies");

            migrationBuilder.RenameTable(
                name: "Cinemas",
                newName: "cinemas");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "actors");

            migrationBuilder.RenameTable(
                name: "Actors_Movies",
                newName: "actor_movies");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_producerId",
                table: "movies",
                newName: "IX_movies_producerId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "actor_movies",
                newName: "movieId");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "actor_movies",
                newName: "actorId");

            migrationBuilder.AddColumn<int>(
                name: "producerId1",
                table: "movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "actorId1",
                table: "actor_movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_producers",
                table: "producers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_movies",
                table: "movies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cinemas",
                table: "cinemas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actors",
                table: "actors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actor_movies",
                table: "actor_movies",
                columns: new[] { "actorId", "movieId" });

            migrationBuilder.CreateIndex(
                name: "IX_movies_producerId1",
                table: "movies",
                column: "producerId1");

            migrationBuilder.CreateIndex(
                name: "IX_actor_movies_actorId1",
                table: "actor_movies",
                column: "actorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_actor_movies_actors_actorId1",
                table: "actor_movies",
                column: "actorId1",
                principalTable: "actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_actor_movies_movies_actorId",
                table: "actor_movies",
                column: "actorId",
                principalTable: "movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
