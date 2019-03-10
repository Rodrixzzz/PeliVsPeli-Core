using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeliVsPeli_Core.Models.DTO;
using PeliVsPeli_Core.Models.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeliVsPeli_Core.Controllers
{
    [Route("/actores")]
    public class ActorController : Controller
    {
        private IRepositoryWrapper _repoWrapper;
        public ActorController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<GenericDTO> Get()
        {
            return _repoWrapper.Actor.GetAll().Select(a => new GenericDTO(a)).OrderBy(a=>a.nombre).ToList();
        }
    }
}
