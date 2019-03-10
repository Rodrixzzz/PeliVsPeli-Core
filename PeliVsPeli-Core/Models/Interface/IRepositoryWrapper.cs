using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliVsPeli_Core.Models.Interface
{
    public interface IRepositoryWrapper
    {
        IActorRepo Actor{ get; }
        ICompetitionRepo Competition { get; }
        IDirectorRepo Director { get; }
        IGenreRepo Genre {get; }
        IMovieRepo Movie { get; }
        IVoteRepo Vote { get; }

    }
}
