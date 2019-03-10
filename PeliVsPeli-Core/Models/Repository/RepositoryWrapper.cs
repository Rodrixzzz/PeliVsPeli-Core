using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeliVsPeli_Core.Models.Interface;

namespace PeliVsPeli_Core.Models.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private EFContex _context;
        private IActorRepo _actor;
        private ICompetitionRepo _competition;
        private IDirectorRepo _director;
        private IGenreRepo _genre;
        private IMovieRepo _movie;
        private IVoteRepo _vote;

        public RepositoryWrapper(EFContex Context)
        {
            _context = Context;
        }
        public IActorRepo Actor
        {
            get
            {
                if(_actor == null)
                {
                    _actor = new ActorRepo(_context);
                }
                return _actor;
            }
        }
        public ICompetitionRepo Competition
        {
            get
            {
                if (_competition == null)
                {
                    _competition = new CompetitionRepo(_context);
                }
                return _competition;
            }
        }
        public IDirectorRepo Director
        {
            get
            {
                if (_director == null)
                {
                    _director = new DirectorRepo(_context);
                }
                return _director;
            }
        }
        public IGenreRepo Genre
        {
            get
            {
                if (_genre == null)
                {
                    _genre = new GenreRepo(_context);
                }
                return _genre;
            }
        }
        public IMovieRepo Movie
        {
            get
            {
                if (_movie == null)
                {
                    _movie = new MovieRepo(_context);
                }
                return _movie;
            }
        }
        public IVoteRepo Vote
        {
            get
            {
                if (_vote == null)
                {
                    _vote = new VoteRepo(_context);
                }
                return _vote;
            }
        }
    }
}
