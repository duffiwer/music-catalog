﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMusic2.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int AlbumId { get; set; }
        public int CompilationId { get; set; }

    }
}
