using PeliVsPeli_Core.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeliVsPeli_Core.Models.DTO;

namespace PeliVsPeli_Core.Models.Repository
{
    public class CompetitionRepo : Repository<Competition>, ICompetitionRepo
    {
        public CompetitionRepo(EFContex contex) : base(contex)
        {

        }

    }
}
