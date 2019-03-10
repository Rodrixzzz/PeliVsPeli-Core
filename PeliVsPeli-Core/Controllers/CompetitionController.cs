using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeliVsPeli_Core.Models;
using PeliVsPeli_Core.Models.DTO;
using PeliVsPeli_Core.Models.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeliVsPeli_Core.Controllers
{
    [Route("/competencias")]
    public class CompetitionController : Controller
    {
        private IRepositoryWrapper _repoWrapper;
        public CompetitionController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<CompetitionDTO> GetAll()
        {
            var competitions = _repoWrapper.Competition.GetAll();
            var listDTO = new List<CompetitionDTO>();
            foreach (var item in competitions)
            {
                var element = new CompetitionDTO(item);
                if(item.ActorId != null)
                    element.actor_nombre = _repoWrapper.Actor.GetById(a => a.Id ==(int)item.ActorId).Name;
                if(item.DirectorId != null)
                    element.director_nombre = _repoWrapper.Director.GetById(d=> d.Id == (int)item.DirectorId).Name;
                if (item.GenreId != null)
                    element.genero_nombre = _repoWrapper.Genre.GetById(g => g.Id == (int)item.GenreId).Name;
                listDTO.Add(element);
            }
            return listDTO;

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public CompetitionDTO Get(int id)
        {
            var CompDB = _repoWrapper.Competition.GetById(c => c.Id == id);
            var CompDTO = new CompetitionDTO(CompDB);
            if (CompDB.ActorId != null)
                CompDTO.actor_nombre = _repoWrapper.Actor.GetById(a => a.Id == (int)CompDB.ActorId).Name;
            if (CompDB.DirectorId != null)
                CompDTO.director_nombre = _repoWrapper.Director.GetById(d => d.Id == (int)CompDB.DirectorId).Name;
            if (CompDB.GenreId != null)
                CompDTO.genero_nombre = _repoWrapper.Genre.GetById(g => g.Id == (int)CompDB.GenreId).Name;
            return CompDTO;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
