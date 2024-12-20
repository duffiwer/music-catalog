﻿using System.Windows.Forms;
using WinFormsMusic2.Models;
using WinFormsMusic2.Services;

namespace WinFormsMusic2
{
    partial class CompilationDetailsForm : Form
    {


        private Compilation _compilation;
        private MusicCatalog _catalog;
        public CompilationDetailsForm(Compilation compilation, MusicCatalog catalog)
        {
            InitializeComponent();
            _compilation = compilation;
            _catalog = catalog;
            LoadCompilationDetails();
            tracksListBox.DoubleClick += TracksListBox_DoubleClick;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void LoadCompilationDetails()
        {
            compilationTitleLabel.Text = "Название сборника: " + _compilation.Title;
            compilationYearLabel.Text = "Год выпуска: " + _compilation.ReleaseYear;

           
            var tracks = _catalog.Tracks.Where(t => t.CompilationId == _compilation.Id).ToList();
            tracksListBox.DataSource = tracks;
            tracksListBox.DisplayMember = "Title";
          
           
        }


        private void TracksListBox_DoubleClick(object sender, EventArgs e)
        {
            if (tracksListBox.SelectedItem is Track selectedTrack)
            {
                var album = _catalog.Albums.FirstOrDefault(a => a.Id == selectedTrack.AlbumId);

                if (album != null)
                {
                    var artist = _catalog.Artists.FirstOrDefault(a => a.Id == album.ArtistId);
                    MessageBox.Show(artist != null ? "Исполнитель: " + artist.Name : "Исполнитель для выбранного трека не найден.", "Информация об исполнителе");
                }
                else
                {
                    MessageBox.Show("Альбом для выбранного трека не найден.", "Ошибка");
                }
            }
        }

    }
}
