﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeliVsPeli_Core.Models;

namespace PeliVsPeli_Core.Migrations
{
    [DbContext(typeof(EFContex))]
    partial class EFContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PeliVsPeli_Core.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(1928),
                            Name = "Tom Hanks"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(1941),
                            Name = "Robin Wright"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(1941),
                            Name = "Matt Damon"
                        });
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.ActorMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActorId");

                    b.Property<int>("MovieId");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("ActorMovie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 2,
                            ActorId = 2,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 3,
                            ActorId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 4,
                            ActorId = 3,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 5,
                            ActorId = 1,
                            MovieId = 3
                        });
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActorId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int?>("DirectorId");

                    b.Property<int?>("GenreId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("DirectorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(6601),
                            Name = "Steven Spielberg"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(6610),
                            Name = "Robert Zemeckis"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(6610),
                            Name = "George Lucas"
                        });
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.DirectorMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DirectorId");

                    b.Property<int>("MovieId");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.HasIndex("MovieId");

                    b.ToTable("DirectorMovie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DirectorId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 2,
                            DirectorId = 1,
                            MovieId = 3
                        },
                        new
                        {
                            Id = 3,
                            DirectorId = 2,
                            MovieId = 1
                        });
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 489, DateTimeKind.Local).AddTicks(1535),
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 489, DateTimeKind.Local).AddTicks(9947),
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 489, DateTimeKind.Local).AddTicks(9954),
                            Name = "Comedy"
                        });
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("Duration");

                    b.Property<int>("GenreId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Plot");

                    b.Property<string>("Poster");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<int>("ReleaseYear");

                    b.Property<float>("Score");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(2866),
                            Duration = 142,
                            GenreId = 3,
                            Name = "Forrest Gump",
                            Plot = "Forrest Gump recounts his life story to strangers who sit next to him on a bench at a bus stop in Savannah, Georgia",
                            Poster = "http://www.mattblank.com/movies/wp-content/uploads/z4ROnCrL77ZMzT0MsNXY5j25wS2-300x450.jpg",
                            ReleaseDate = new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReleaseYear = 1994,
                            Score = 10f
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(5807),
                            Duration = 169,
                            GenreId = 1,
                            Name = "Saving Private Ryan",
                            Plot = "The story begins on June 6, 1944 in Normandy at Omaha Beach. Captain John Miller (Tom Hanks) and his men land on a beach where the battle rages. The American soldiers are massacred on the Norman beaches and only survive those who take shelter of a dune. But impossible to go further.",
                            Poster = "https://www.filmnod.com/media/poster/s/saving-private-ryan-1998-poster.jpg",
                            ReleaseDate = new DateTime(1998, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReleaseYear = 1998,
                            Score = 10f
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2019, 3, 10, 18, 0, 25, 490, DateTimeKind.Local).AddTicks(5826),
                            Duration = 128,
                            GenreId = 2,
                            Name = "The Terminal",
                            Plot = "Viktor Navorski, a traveler from the fictional country Krakozhia, arrives at New York's John F. Kennedy International Airport, only to find that his passport is suddenly no longer valid. The United States no longer recognizes Krakozhia as a sovereign nation after the outbreak of a civil war, and Viktor is not permitted to either enter the country or return home as he is now stateless. Because of this, Customs seizes his passport and airline ticket.",
                            Poster = "http://www.mattblank.com/movies/wp-content/uploads/f4Dup6awDfDqAHKgWqNJ2HFw1qN-300x450.jpg",
                            ReleaseDate = new DateTime(2004, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReleaseYear = 2004,
                            Score = 8f
                        });
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompetitionId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int?>("MovieId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("MovieId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.ActorMovie", b =>
                {
                    b.HasOne("PeliVsPeli_Core.Models.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PeliVsPeli_Core.Models.Movie", "Movie")
                        .WithMany("Actors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.Competition", b =>
                {
                    b.HasOne("PeliVsPeli_Core.Models.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId");

                    b.HasOne("PeliVsPeli_Core.Models.Director", "Director")
                        .WithMany()
                        .HasForeignKey("DirectorId");

                    b.HasOne("PeliVsPeli_Core.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId");
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.DirectorMovie", b =>
                {
                    b.HasOne("PeliVsPeli_Core.Models.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PeliVsPeli_Core.Models.Movie", "Movie")
                        .WithMany("Directors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.Movie", b =>
                {
                    b.HasOne("PeliVsPeli_Core.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PeliVsPeli_Core.Models.Vote", b =>
                {
                    b.HasOne("PeliVsPeli_Core.Models.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("CompetitionId");

                    b.HasOne("PeliVsPeli_Core.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId");
                });
#pragma warning restore 612, 618
        }
    }
}
