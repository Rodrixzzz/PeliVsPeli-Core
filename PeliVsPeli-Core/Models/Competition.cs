using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliVsPeli_Core.Models
{
    public class Competition:Entidad
    {
        public Genre Genre { get; set; }
        public int? GenreId { get; set; }
        public Director Director { get; set; }
        public int? DirectorId { get; set; }
        public Actor Actor { get; set; }
        public int? ActorId { get; set; }
    }
}
