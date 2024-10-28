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
            tracksListBox.DoubleClick += TracksListBox_DoubleClick;
        }
        private void InitializeComponent()
        {
            this.compilationTitleLabel = new Label();
            this.compilationYearLabel = new Label();
            this.tracksListBox = new ListBox();
 

            this.compilationTitleLabel.AutoSize = true;
            this.compilationTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.compilationTitleLabel.Text = "Название сборника";

            this.compilationYearLabel.AutoSize = true;
            this.compilationYearLabel.Location = new System.Drawing.Point(20, 50);
            this.compilationYearLabel.Text = "Год релиза";

            this.tracksListBox.Location = new System.Drawing.Point(20, 80);
            this.tracksListBox.Size = new System.Drawing.Size(200, 150);

            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.compilationTitleLabel);
            this.Controls.Add(this.tracksListBox);
            this.Controls.Add(this.compilationYearLabel);
            
            this.Text = "Информация о сборнике";
        }
        
        
        private Label compilationTitleLabel;
        private ListBox tracksListBox;
        private Label compilationYearLabel;

    }
}
