using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliVsPeli_Core.Models
{
    public class Director:Entidad
    {
        public virtual ICollection<DirectorMovie> Movies { get; set; }
    }
}
