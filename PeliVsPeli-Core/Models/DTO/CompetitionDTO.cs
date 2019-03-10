using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeliVsPeli_Core.Models;

namespace PeliVsPeli_Core.Models.DTO
{
    public class CompetitionDTO
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string genero_nombre { get; set; }
        public string actor_nombre { get; set; }
        public string director_nombre { get; set; }
        public CompetitionDTO()
        {

        }
        public CompetitionDTO( Competition competition)
        {
            Id = competition.Id;
            nombre = competition.Name;
            genero_nombre = competition.Genre == null?string.Empty : competition.Genre.Name;
            actor_nombre = competition.Actor == null ? string.Empty : competition.Actor.Name;
            director_nombre = competition.Director == null ? string.Empty : competition.Director.Name;
        }
    }
}
