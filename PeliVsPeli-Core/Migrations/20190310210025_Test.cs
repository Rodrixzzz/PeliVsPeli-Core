using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeliVsPeli_Core.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    GenreId = table.Column<int>(nullable: true),
                    DirectorId = table.Column<int>(nullable: true),
                    ActorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competitions_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Competitions_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Competitions_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    GenreId = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    ReleaseYear = table.Column<int>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Score = table.Column<float>(nullable: false),
                    Poster = table.Column<string>(nullable: true),
                    Plot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(nullable: false),
                    ActorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectorMovie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(nullable: false),
                    DirectorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorMovie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DirectorMovie_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectorMovie_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    MovieId = table.Column<int>(nullable: true),
                    CompetitionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votes_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votes_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(1928), "Tom Hanks" },
                    { 2, new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(1941), "Robin Wright" },
                    { 3, new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(1941), "Matt Damon" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(6601), "Steven Spielberg" },
                    { 2, new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(6610), "Robert Zemeckis" },
                    { 3, new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(6610), "George Lucas" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 3, 10, 18, 0, 25, 489, DateTimeKind.Local).AddTicks(1535), "Action" },
                    { 2, new DateTime(2019, 3, 10, 18, 0, 25, 489, DateTimeKind.Local).AddTicks(9947), "Drama" },
                    { 3, new DateTime(2019, 3, 10, 18, 0, 25, 489, DateTimeKind.Local).AddTicks(9954), "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateCreated", "Duration", "GenreId", "Name", "Plot", "Poster", "ReleaseDate", "ReleaseYear", "Score" },
                values: new object[] { 2, new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(5807), 169, 1, "Saving Private Ryan", "The story begins on June 6, 1944 in Normandy at Omaha Beach. Captain John Miller (Tom Hanks) and his men land on a beach where the battle rages. The American soldiers are massacred on the Norman beaches and only survive those who take shelter of a dune. But impossible to go further.", "https://www.filmnod.com/media/poster/s/saving-private-ryan-1998-poster.jpg", new DateTime(1998, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1998, 10f });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateCreated", "Duration", "GenreId", "Name", "Plot", "Poster", "ReleaseDate", "ReleaseYear", "Score" },
                values: new object[] { 3, new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(5826), 128, 2, "The Terminal", "Viktor Navorski, a traveler from the fictional country Krakozhia, arrives at New York's John F. Kennedy International Airport, only to find that his passport is suddenly no longer valid. The United States no longer recognizes Krakozhia as a sovereign nation after the outbreak of a civil war, and Viktor is not permitted to either enter the country or return home as he is now stateless. Because of this, Customs seizes his passport and airline ticket.", "http://www.mattblank.com/movies/wp-content/uploads/f4Dup6awDfDqAHKgWqNJ2HFw1qN-300x450.jpg", new DateTime(2004, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2004, 8f });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateCreated", "Duration", "GenreId", "Name", "Plot", "Poster", "ReleaseDate", "ReleaseYear", "Score" },
                values: new object[] { 1, new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(2866), 142, 3, "Forrest Gump", "Forrest Gump recounts his life story to strangers who sit next to him on a bench at a bus stop in Savannah, Georgia", "http://www.mattblank.com/movies/wp-content/uploads/z4ROnCrL77ZMzT0MsNXY5j25wS2-300x450.jpg", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1994, 10f });

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

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_ActorId",
                table: "ActorMovie",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MovieId",
                table: "ActorMovie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_ActorId",
                table: "Competitions",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_DirectorId",
                table: "Competitions",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_GenreId",
                table: "Competitions",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorMovie_DirectorId",
                table: "DirectorMovie",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorMovie_MovieId",
                table: "DirectorMovie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_CompetitionId",
                table: "Votes",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_MovieId",
                table: "Votes",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovie");

            migrationBuilder.DropTable(
                name: "DirectorMovie");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
