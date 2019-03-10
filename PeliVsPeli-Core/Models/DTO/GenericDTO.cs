using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeliVsPeli_Core.Models;

namespace PeliVsPeli_Core.Models.DTO
{
    public class GenericDTO
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public GenericDTO()
        {

        }
        public GenericDTO(Entidad Generic)
        {
            Id = Generic.Id;
            nombre = Generic.Name;
        }
    }
}
