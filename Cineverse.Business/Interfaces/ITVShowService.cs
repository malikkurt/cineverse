using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cineverse.Entities.Models;

namespace Cineverse.Business.Interfaces
{
    public interface ITVShowService
    {
        IEnumerable<TVShow> GetAllTVShows();
        TVShow GetTVShow(int id);
        void AddTVShow(TVShow tvshow);
        void UpdateTVShow(TVShow tvshow);
        void DeleteTVShow(int id);
    }
}
