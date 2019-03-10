using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliVsPeli_Core.Models
{
    public class Person:Entidad
    {
        public DateTime Birth { get; set; }
        ICollection<Movie> Movies { get; set; }
    }
}
