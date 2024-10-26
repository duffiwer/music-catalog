using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMusic2.Models;

namespace WinFormsMusic2.Builders
{
    public class ArtistBuilder
    {
        private Artist _artist = new Artist();
        public ArtistBuilder SetName(string name)
        {
            _artist.Name = name;
            return this;
        }
        public ArtistBuilder SetGenre(string genre)
        {
            _artist.Genre = genre;
            return this;
        }
        public Artist Build() => _artist;
    }
}
