using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMusic2.Models;
using WinFormsMusic2.Services;

namespace WinFormsMusic2.SearchStrategies
{
    
   public class ArtistSearchStrategy : ISearchStrategy
    {
        public List<object> Search(MusicCatalog catalog, string query)
        {
            return catalog.Artists
                .Where(a => a.Name.ToLower().Contains(query))
                .Cast<object>()
                .ToList();
        }
    }
}
