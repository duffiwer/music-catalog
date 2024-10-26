﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMusic2.Services;

namespace WinFormsMusic2.SearchStrategies
{
    public class CompilationSearchStrategy : ISearchStrategy
    {
        public List<object> Search(MusicCatalog catalog, string query)
        {
            return catalog.Compilations
                .Where(c => c.Title.ToLower().Contains(query))
                .Cast<object>()
                .ToList();
        }
    }
}