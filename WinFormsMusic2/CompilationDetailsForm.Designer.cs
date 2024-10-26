using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsMusic2.Models;
using WinFormsMusic2.Services;

namespace WinFormsMusic2
{
    public partial class CompilationDetailsForm : Form
    {
        private Compilation _compilation;
        private MusicCatalog _catalog;

        public CompilationDetailsForm(Compilation compilation, MusicCatalog catalog)
        {
            InitializeComponent();
            _compilation = compilation;
            _catalog = catalog;
            LoadCompilationDetails();
        }

        private void LoadCompilationDetails()
        {
            compilationTitleLabel.Text = _compilation.Title;
            compilationYearLabel.Text = _compilation.ReleaseYear.ToString(); 

            var tracks = _catalog.Tracks.Where(t => t.CompilationId == _compilation.Id).ToList();
            tracksListBox.DataSource = tracks;
            tracksListBox.DisplayMember = "Title"; 

            var artists = _catalog.Artists.Where(a => a.Compilations.Any(c => c.Id == _compilation.Id)).ToList();
            artistsListBox.DataSource = artists;
            artistsListBox.DisplayMember = "Name"; 
        }
    }
}
