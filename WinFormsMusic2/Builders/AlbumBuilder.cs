using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMusic2.Models;

namespace WinFormsMusic2.Builders
{
    public class AlbumBuilder
    {
        private Album _album = new Album();
        public AlbumBuilder SetTitle(string title)
        {
            _album.Title = title;
            return this;
        }
        public AlbumBuilder SetReleaseYear(int year)
        {
            _album.ReleaseYear = year;
            return this;
        }
        public AlbumBuilder AddTrack(Track track)
        {
            _album.Tracks.Add(track);
            return this;
        }
        public Album Build() => _album;
    }
}
