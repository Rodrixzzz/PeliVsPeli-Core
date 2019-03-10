using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliVsPeli_Core.Models
{
    public class Vote:Entidad
    {
        public Movie Movie {get; set; }
        public int? MovieId { get; set; }
        public Competition Competition { get; set; }
        public int? CompetitionId { get; set; }
    }
}
