using Cineverse.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cineverse.Entities.Models;

namespace Cineverse.Business.Interfaces
{
    public interface IWatchlistService
    {
        IEnumerable<Watchlist> GetAllWatchlists();
        Watchlist GetWatchlistById(int id);
        void AddWatchlist(Watchlist watchlist);
        void UpdateWatchlist(Watchlist watchlist);
        void DeleteWatchlist(int id);
    }
}
