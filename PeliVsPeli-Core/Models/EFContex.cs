using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliVsPeli_Core.Models
{
    public class EFContex : DbContext
    {
        public EFContex(DbContextOptions<EFContex> options) : base(options)
        { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        
    }
}
//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    modelBuilder.Entity<DirectorMovie>()
//        .HasKey(t => new { t.DirectorId, t.MovieId });
//    modelBuilder.Entity<DirectorMovie>()
//        .HasOne(m => m.Movie)
//        .WithMany(m => m.Directors)
//        .HasForeignKey(m => m.MovieId);
//    modelBuilder.Entity<DirectorMovie>()
//        .HasOne(d => d.Director)
//        .WithMany(d => d.Movies)
//        .HasForeignKey(d => d.DirectorId);

//    modelBuilder.Entity<ActorMovie>()
//        .HasKey(t => new { t.ActorId, t.MovieId });
//    modelBuilder.Entity<ActorMovie>()
//        .HasOne(m => m.Movie)
//        .WithMany(m => m.Actors)
//        .HasForeignKey(m => m.MovieId);
//    modelBuilder.Entity<ActorMovie>()
//        .HasOne(a => a.Actor)
//        .WithMany(a => a.Movies)
//        .HasForeignKey(a => a.ActorId);

//}
//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    modelBuilder.Entity<Genre>().HasData(new Genre
//    {
//        Id = 1,
//        Name = "Action",
//        DateCreated = DateTime.Now
//    }, new Genre
//    {
//        Id = 2,
//        Name = "Drama",
//        DateCreated = DateTime.Now

//    }, new Genre
//    {
//        Id = 3,
//        Name = "Comedy",
//        DateCreated = DateTime.Now
//    });
//    modelBuilder.Entity<Actor>().HasData(new Actor
//    {
//        Id = 1,
//        Name = "Tom Hanks",
//        DateCreated = DateTime.Now
//    }, new Actor
//    {
//        Id = 2,
//        Name = "Robin Wright",
//        DateCreated = DateTime.Now

//    }, new Actor
//    {
//        Id = 3,
//        Name = "Matt Damon",
//        DateCreated = DateTime.Now
//    });
//    modelBuilder.Entity<Movie>().HasData(new Movie
//    {
//        Id = 1,
//        Name = "Forrest Gump",
//        DateCreated = DateTime.Now,
//        GenreId = 3,
//        Poster = "http://www.mattblank.com/movies/wp-content/uploads/z4ROnCrL77ZMzT0MsNXY5j25wS2-300x450.jpg",
//        Duration = 142,
//        Plot = "Forrest Gump recounts his life story to strangers who sit next to him on a bench at a bus stop in Savannah, Georgia",
//        ReleaseDate = new DateTime(1994, 7, 6, 0, 0, 0, 0),
//        ReleaseYear = 1994,
//        Score = 10.0f
//    }, new Movie
//    {
//        Id = 2,
//        Name = "Saving Private Ryan",
//        DateCreated = DateTime.Now,
//        GenreId = 1,
//        Poster = "https://www.filmnod.com/media/poster/s/saving-private-ryan-1998-poster.jpg",
//        Duration = 169,
//        Plot = "The story begins on June 6, 1944 in Normandy at Omaha Beach. Captain John Miller (Tom Hanks) and his men land on a beach where the battle rages. The American soldiers are massacred on the Norman beaches and only survive those who take shelter of a dune. But impossible to go further.",
//        ReleaseDate = new DateTime(1998, 7, 28, 0, 0, 0, 0),
//        ReleaseYear = 1998,
//        Score = 10.0f

//    }, new Movie
//    {
//        Id = 3,
//        Name = "The Terminal",
//        DateCreated = DateTime.Now,
//        GenreId = 2,
//        Poster = "http://www.mattblank.com/movies/wp-content/uploads/f4Dup6awDfDqAHKgWqNJ2HFw1qN-300x450.jpg",
//        Duration = 128,
//        Plot = "Viktor Navorski, a traveler from the fictional country Krakozhia, arrives at New York's John F. Kennedy International Airport, only to find that his passport is suddenly no longer valid. The United States no longer recognizes Krakozhia as a sovereign nation after the outbreak of a civil war, and Viktor is not permitted to either enter the country or return home as he is now stateless. Because of this, Customs seizes his passport and airline ticket.",
//        ReleaseDate = new DateTime(2004, 6, 18, 0, 0, 0, 0),
//        ReleaseYear = 2004,
//        Score = 8.0f
//    });
//    modelBuilder.Entity<Director>().HasData(new Director
//    {
//        Id = 1,
//        Name = "Steven Spielberg",
//        DateCreated = DateTime.Now
//    }, new Director
//    {
//        Id = 2,
//        Name = "Robert Zemeckis",
//        DateCreated = DateTime.Now

//    }, new Director
//    {
//        Id = 3,
//        Name = "George Lucas",
//        DateCreated = DateTime.Now
//    });
//    modelBuilder.Entity<ActorMovie>().HasData(new ActorMovie
//    {
//        Id = 1,
//        ActorId = 1,
//        MovieId = 1
//    }, new ActorMovie
//    {
//        Id = 2,
//        ActorId = 2,
//        MovieId = 1
//    }, new ActorMovie
//    {
//        Id = 3,
//        ActorId = 1,
//        MovieId = 2
//    }, new ActorMovie
//    {
//        Id = 4,
//        ActorId = 3,
//        MovieId = 2
//    }, new ActorMovie
//    {
//        Id = 5,
//        ActorId = 1,
//        MovieId = 3
//    });
//    modelBuilder.Entity<DirectorMovie>().HasData(new DirectorMovie
//    {
//        Id = 1,
//        DirectorId = 1,
//        MovieId = 2
//    }, new DirectorMovie
//    {
//        Id = 2,
//        DirectorId = 1,
//        MovieId = 3
//    }, new DirectorMovie
//    {
//        Id = 3,
//        DirectorId = 2,
//        MovieId = 1
//    });
//}