﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeliVsPeli_Core.Models.Interface;

namespace PeliVsPeli_Core.Models.Repository
{
    public class MovieRepo:Repository<Movie>,IMovieRepo
    {
        public MovieRepo(EFContex contex):base(contex)
        {

        }
    }
}
