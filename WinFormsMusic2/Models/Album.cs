using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMusic2.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int ArtistId { get; set; }
        public List<Track> Tracks { get; set; } = new List<Track>();
    }
}
