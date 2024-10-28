using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMusic2.Models
{
    public class Compilation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Track> Tracks { get; set; } = new List<Track>();
        public List<int> TrackIds { get; set; } = new List<int>(); 
        public int ReleaseYear { get; set; }

        public override string ToString()
        {
            return $"{Title} ({ReleaseYear})";
        }
    }
}
