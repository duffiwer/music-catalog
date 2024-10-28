using System;
using System.Collections.Generic;
using System.Linq;
using WinFormsMusic2.Models;
using WinFormsMusic2.Services;

namespace WinFormsMusic2.SearchStrategies
{
    public class TrackSearchStrategy : ISearchStrategy
    {
        public List<object> Search(MusicCatalog catalog, string query)
        {
            if (catalog == null || string.IsNullOrEmpty(query))
            {
                throw new ArgumentNullException("Catalog или query не могут быть null.");
            }

            return catalog.Tracks
                .Where(t => t.Title.ToLower().Contains(query.ToLower()))
                .Cast<object>()
                .ToList();
        }
    }
}