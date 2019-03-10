using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliVsPeli_Core.Models
{
    public class Movie:Entidad
    {
        public ICollection<Actor> Actors { get; set; }
        public int Duration { get; set; }
    }
}
