using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsMusic2.Models;
using WinFormsMusic2.Services;

namespace WinFormsMusic2
{
    public partial class AlbumDetailsForm : Form
    {
        private Album _album;
        private MusicCatalog _catalog;

        public AlbumDetailsForm(Album album, MusicCatalog catalog)
        {
            InitializeComponent();
            _album = album;
            _catalog = catalog;
            LoadAlbumDetails();
        }

        private void LoadAlbumDetails()
        {
            albumTitleLabel.Text = "Название: "+_album.Title;
            albumReleaseDateLabel.Text = _album.ReleaseYear.ToString()+"\n\n\nТреки";

            var artist = _catalog.Artists.FirstOrDefault(a => a.Id == _album.ArtistId);
            if (artist != null)
            {
                albumArtistLabel.Text ="Исполнитель: "+ artist.Name; 
            }

            var tracks = _catalog.Tracks.Where(t => t.AlbumId == _album.Id).ToList();
            tracksListBox.DataSource = tracks;
            tracksListBox.DisplayMember = "Title"; 
        }

    }
}