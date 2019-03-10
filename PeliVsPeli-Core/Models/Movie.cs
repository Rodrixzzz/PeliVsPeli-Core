using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliVsPeli_Core.Models
{
    public class Movie:Entidad
    {   
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public int Duration { get; set; }
        public int ReleaseYear { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float Score { get; set; }
        public string Poster { get; set; }
        public string Plot { get; set; }
        public virtual ICollection<ActorMovie> Actors { get; set; }
        public virtual ICollection<DirectorMovie> Directors  { get; set; }
    }
}
