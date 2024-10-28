using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMusic2.Models;
using WinFormsMusic2.Services;

namespace WinFormsMusic2.SearchStrategies
{
    public class CompilationSearchStrategy : ISearchStrategy
    {
        public List<object> Search(MusicCatalog catalog, string query)
        {
            if (catalog == null || string.IsNullOrEmpty(query))
            {
                throw new ArgumentNullException("Catalog или query не могут быть null.");
            }

            return catalog.Compilations
                 .Where(a => a.Title.ToLower().Contains(query))
                 .Cast<object>()
                 .ToList();

        }
    }
}
