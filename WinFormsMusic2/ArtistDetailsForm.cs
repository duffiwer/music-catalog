using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMusic2.Models;
using WinFormsMusic2.Services;

namespace WinFormsMusic2
{

    public partial class ArtistDetailsForm : Form
    {
        private Artist _artist;
        private MusicCatalog _catalog;

        public ArtistDetailsForm(Artist artist, MusicCatalog catalog)
        {
            InitializeComponent();
            _artist = artist;
            _catalog = catalog;
            LoadArtistDetails();
            albumsListBox.DoubleClick += albumsListBox_DoubleClick;
        }

        private void LoadArtistDetails()
        {
            artistNameLabel.Text = "Исполнитель: "+_artist.Name;
            artistGenreLabel.Text = "Жанр: "+_artist.Genre;
            artistTracksLabel.Text = "Треки";
            artistAlbumsLabel.Text = "Альбомы";
            var albums = _catalog.Albums.Where(a => a.ArtistId == _artist.Id).ToList();
            albumsListBox.DataSource = albums;
            albumsListBox.DisplayMember = "Title"; 

            if (albums.Count > 0)
            {
                var firstAlbum = albums.First();
                var tracks = _catalog.Tracks.Where(t => t.AlbumId == firstAlbum.Id).ToList();
                tracksListBox.DataSource = tracks;
                tracksListBox.DisplayMember = "Title"; 
            }
            else
            {
                tracksListBox.DataSource = null; 
            }
        }
        private void albumsListBox_DoubleClick(object sender, EventArgs e)
        {
            var selectedAlbum = albumsListBox.SelectedItem as Album;
            if (selectedAlbum != null)
            {
                var tracks = _catalog.Tracks.Where(t => t.AlbumId == selectedAlbum.Id).ToList();

                tracksListBox.DataSource = tracks;
                tracksListBox.DisplayMember = "Title"; 
            }
        }
    }
}
