using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMusic2.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public List<Compilation> Compilations { get; set; } = new List<Compilation>();

    }
}
