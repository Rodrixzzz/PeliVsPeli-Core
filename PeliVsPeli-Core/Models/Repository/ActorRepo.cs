using PeliVsPeli_Core.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliVsPeli_Core.Models.Repository
{
    public class ActorRepo:Repository<Actor>,IActorRepo
    {
        public ActorRepo(EFContex contex) : base(contex)
        {

        }
    }
}
