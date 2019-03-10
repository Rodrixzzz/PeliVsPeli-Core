using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliVsPeli_Core.Models
{
    public class Genre:Entidad
    {
       public virtual ICollection<Movie> Movies { get; set; }
    }
}
