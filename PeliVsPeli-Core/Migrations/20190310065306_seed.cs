using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeliVsPeli_Core.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Movies",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 3, 10, 3, 53, 5, 743, DateTimeKind.Local).AddTicks(479), "Tom Hanks" },
                    { 2, new DateTime(2019, 3, 10, 3, 53, 5, 743, DateTimeKind.Local).AddTicks(492), "Robin Wright" },
                    { 3, new DateTime(2019, 3, 10, 3, 53, 5, 743, DateTimeKind.Local).AddTicks(492), "Matt Damon" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 3, 10, 3, 53, 5, 743, DateTimeKind.Local).AddTicks(5513), "Steven Spielberg" },
                    { 2, new DateTime(2019, 3, 10, 3, 53, 5, 743, DateTimeKind.Local).AddTicks(5526), "Robert Zemeckis" },
                    { 3, new DateTime(2019, 3, 10, 3, 53, 5, 743, DateTimeKind.Local).AddTicks(5526), "George Lucas" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 3, 10, 3, 53, 5, 741, DateTimeKind.Local).AddTicks(7717), "Action" },
                    { 2, new DateTime(2019, 3, 10, 3, 53, 5, 742, DateTimeKind.Local).AddTicks(7929), "Drama" },
                    { 3, new DateTime(2019, 3, 10, 3, 53, 5, 742, DateTimeKind.Local).AddTicks(7932), "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateCreated", "Duration", "GenreId", "Name", "Plot", "Poster", "ReleaseDate", "ReleaseYear", "Score" },
                values: new object[] { 2, new DateTime(2019, 3, 10, 3, 53, 5, 743, DateTimeKind.Local).AddTicks(4617), 169, 1, "Saving Private Ryan", "The story begins on June 6, 1944 in Normandy at Omaha Beach. Captain John Miller (Tom Hanks) and his men land on a beach where the battle rages. The American soldiers are massacred on the Norman beaches and only survive those who take shelter of a dune. But impossible to go further.", "https://www.filmnod.com/media/poster/s/saving-private-ryan-1998-poster.jpg", new DateTime(1998, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1998, 10f });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateCreated", "Duration", "GenreId", "Name", "Plot", "Poster", "ReleaseDate", "ReleaseYear", "Score" },
                values: new object[] { 3, new DateTime(2019, 3, 10, 3, 53, 5, 743, DateTimeKind.Local).AddTicks(4639), 128, 2, "The Terminal", "Viktor Navorski, a traveler from the fictional country Krakozhia, arrives at New York's John F. Kennedy International Airport, only to find that his passport is suddenly no longer valid. The United States no longer recognizes Krakozhia as a sovereign nation after the outbreak of a civil war, and Viktor is not permitted to either enter the country or return home as he is now stateless. Because of this, Customs seizes his passport and airline ticket.", "http://www.mattblank.com/movies/wp-content/uploads/f4Dup6awDfDqAHKgWqNJ2HFw1qN-300x450.jpg", new DateTime(2004, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2004, 8f });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateCreated", "Duration", "GenreId", "Name", "Plot", "Poster", "ReleaseDate", "ReleaseYear", "Score" },
                values: new object[] { 1, new DateTime(2019, 3, 10, 3, 53, 5, 743, DateTimeKind.Local).AddTicks(1363), 142, 3, "Forrest Gump", "Forrest Gump recounts his life story to strangers who sit next to him on a bench at a bus stop in Savannah, Georgia", "http://www.mattblank.com/movies/wp-content/uploads/z4ROnCrL77ZMzT0MsNXY5j25wS2-300x450.jpg", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1994, 10f });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 3, 1, 2 },
                    { 4, 3, 2 },
                    { 5, 1, 3 },
                    { 1, 1, 1 },
                    { 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "DirectorMovie",
                columns: new[] { "Id", "DirectorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 3 },
                    { 3, 2, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Movies",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
