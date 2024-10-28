using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinFormsMusic2.Models;
using WinFormsMusic2.SearchStrategies;
using WinFormsMusic2.Services;

namespace WinFormsMusic2
{
    public partial class MainForm : Form
    {
        private MusicCatalog _catalog = new MusicCatalog();
        public MainForm()
        {
            InitializeComponent();
            searchTypeComboBox.Items.AddRange(new string[] { "Исполнители", "Альбомы", "Сборники","Треки" });
            searchTypeComboBox.SelectedIndex = 0;

            _searchStrategy = new ArtistSearchStrategy();
            LoadDefaultData();
            _catalog.SaveTracks();

            searchTypeComboBox.SelectedIndexChanged += (s, e) => SetSearchStrategy();
        }
        private void addArtistButton_Click(object sender, EventArgs e)
        {
            var artist = new Artist
            {
                Name = artistNameTextBox.Text,
                Genre = artistGenreTextBox.Text
            };
            _catalog.AddArtist(artist);
            MessageBox.Show("Исполнитель добавлен!");
            ClearArtistFields();
        }
        private void addTrackButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(trackAlbumIdTextBox.Text, out int albumId)) 
            {
                var track = new Track
                {
                    AlbumId = albumId,
                    Title = trackTitleTextBox.Text,
                    Genre = trackGenreTextBox.Text
                };
                _catalog.AddTrack(track);
                MessageBox.Show("Добавлен трек!");
            }
        }

        private void SetSearchStrategy()
        {
            switch (searchTypeComboBox.SelectedItem.ToString())
            {
                case "Исполнители":
                    _searchStrategy = new ArtistSearchStrategy();
                    break;
                case "Альбомы":
                    _searchStrategy = new AlbumSearchStrategy();
                    break;
                case "Сборники":
                    _searchStrategy = new CompilationSearchStrategy();
                    break;
                case "Треки":
                    _searchStrategy = new TrackSearchStrategy();
                    break;
            }
            LoadDefaultData();
        }
        private void LoadDefaultData()
        {
            if (_searchStrategy is ArtistSearchStrategy)
            {
                resultsListBox.DataSource = _catalog.Artists;
                resultsListBox.DisplayMember = "Name";
            }
            else if (_searchStrategy is AlbumSearchStrategy)
            {
                resultsListBox.DataSource = _catalog.Albums;
                resultsListBox.DisplayMember = "Title";
            }
            else if (_searchStrategy is CompilationSearchStrategy)
            {
                resultsListBox.DataSource = _catalog.Compilations;
                resultsListBox.DisplayMember = "Title";
            }
            else if (_searchStrategy is TrackSearchStrategy)
            {
                resultsListBox.DataSource = _catalog.Tracks;
                resultsListBox.DisplayMember = "Title";
            }

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = searchTextBox.Text.ToLower();
            if (string.IsNullOrWhiteSpace(query) || _searchStrategy == null)
                return;

            var results = _searchStrategy.Search(_catalog, query);

            resultsListBox.DataSource = results;

            if (_searchStrategy is ArtistSearchStrategy)
                resultsListBox.DisplayMember = "Name";
            else
                resultsListBox.DisplayMember = "Title";
        }

        private void ChangeSearchStrategy(ISearchStrategy newStrategy)
        {
            _searchStrategy = newStrategy;
            LoadDefaultData();
        }

        private void DisplayResults(List<object> results)
        {
            resultsListBox.DataSource = results;

            if (results.FirstOrDefault() is Album)
            {
                resultsListBox.DisplayMember = "Title";  
            }
            else if (results.FirstOrDefault() is Artist)
            {
                resultsListBox.DisplayMember = "Name"; 
            }
            else if (results.FirstOrDefault() is Compilation)
            {
                resultsListBox.DisplayMember = "Title";   
            }
            else if (results.FirstOrDefault() is Track)
            {
                resultsListBox.DisplayMember = "Title";
            }
        }


        private void addAlbumButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(albumYearTextBox.Text, out int releaseYear) && int.TryParse(albumArtistIdTextBox.Text, out int artistId))
            {
                var album = new Album
                {
                    Title = albumTitleTextBox.Text,
                    ReleaseYear = releaseYear,
                    ArtistId = artistId
                };
                _catalog.AddAlbum(album);
                MessageBox.Show("Альбом добавлен!");
                ClearAlbumFields();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные данные для года выпуска и ID исполнителя.");
            }
        }
        private void addCompilationButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(compilationYearTextBox.Text, out int releaseYear))
            {
                var compilation = new Compilation
                {
                    Title = compilationTitleTextBox.Text,
                    ReleaseYear = releaseYear
                };
                _catalog.AddCompilation(compilation);
                MessageBox.Show("Сборник добавлен!");
                ClearCompilationFields();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректный год выпуска.");
            }
        }


        private void addTrackToCompilationButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(trackIdTextBox.Text, out int trackId) &&
                int.TryParse(compilationIdTextBox.Text, out int compilationId))
            {
                var trackToAdd = _catalog.Tracks.FirstOrDefault(t => t.Id == trackId);
                var compilation = _catalog.Compilations.FirstOrDefault(c => c.Id == compilationId);

                if (trackToAdd != null && compilation != null)
                {
                    compilation.Tracks.Add(trackToAdd);
                    trackToAdd.CompilationId = compilationId;

                    _catalog.SaveCompilations(); 
                    _catalog.SaveTracks();      
                    MessageBox.Show($"Трек '{trackToAdd.Title}' добавлен в сборник '{compilation.Title}'.");
                }
                else
                {
                    MessageBox.Show("Трек или сборник не найдены.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные ID трека и сборника.");
            }
        }
       

        private void resultsListBox_Click(object sender, EventArgs e)
        {
           
            var selectedItem = resultsListBox.SelectedItem;

            if (selectedItem is Artist selectedArtist)
            {
                var artistDetailsForm = new ArtistDetailsForm(selectedArtist, _catalog);
                artistDetailsForm.Show(); 
            }
            else if (selectedItem is Album selectedAlbum)
            {
               var albumDetailsForm = new AlbumDetailsForm(selectedAlbum, _catalog);
               albumDetailsForm.Show();
            }
            else if (selectedItem is Compilation selectedCompilation)
            {
                var compilationDetailsForm = new CompilationDetailsForm(selectedCompilation, _catalog);
                compilationDetailsForm.Show();
            }
            else if (selectedItem is Track selectedTrack)
            {
                var trackDetailsForm = new TrackDetailsForm(selectedTrack, _catalog);
                trackDetailsForm.Show();
            }
        }
        
        private void ClearArtistFields()
        {
            artistNameTextBox.Clear();
            artistGenreTextBox.Clear();
        }

        private void ClearAlbumFields()
        {
            albumTitleTextBox.Clear();
            albumYearTextBox.Clear();
            albumArtistIdTextBox.Clear();
        }

        private void ClearCompilationFields()
        {
            compilationTitleTextBox.Clear();
            compilationYearTextBox.Clear();
        }
        private void ClearTrackFields()
        {
            trackAlbumIdTextBox.Clear();
            trackTitleTextBox.Clear();
            trackGenreTextBox.Clear();
        }
    }
}
