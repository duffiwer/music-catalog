using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMusic2.Services;
using WinFormsMusic2.Models;


namespace WinFormsMusic2
{
    public partial class TrackDetailsForm : Form
    {
        private Track _track;
        private MusicCatalog _catalog;
        public TrackDetailsForm(Track track, MusicCatalog catalog)
        {
            InitializeComponent();
            _track = track;
            _catalog = catalog;
            LoadTrackDetails();
        }
        private void LoadTrackDetails()
        {
            var album = _catalog.Albums.FirstOrDefault(a => a.Id == _track.AlbumId);
            var artist = album != null ? _catalog.Artists.FirstOrDefault(a => a.Id == album.ArtistId) : null;

            trackTitleLabel.Text = "Название трека: " + _track.Title;
            trackGenreLabel.Text = "Жанр: " + _track.Genre;
            trackAlbumLabel.Text = "Альбом: " + (album?.Title ?? "Неизвестен");
            trackArtistLabel.Text = "Исполнитель: " + (artist?.Name ?? "Неизвестен");
        }
    }
}
