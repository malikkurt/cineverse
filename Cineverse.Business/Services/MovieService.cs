using Cineverse.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cineverse.Business.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieService _movieService;
    }
}
