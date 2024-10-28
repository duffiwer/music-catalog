using WinFormsMusic2.SearchStrategies;

namespace WinFormsMusic2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.addArtistButton = new System.Windows.Forms.Button();
            this.artistNameTextBox = new System.Windows.Forms.TextBox();
            this.artistGenreTextBox = new System.Windows.Forms.TextBox();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.albumTitleTextBox = new System.Windows.Forms.TextBox();
            this.albumYearTextBox = new System.Windows.Forms.TextBox();
            this.albumArtistIdTextBox = new System.Windows.Forms.TextBox();
            this.addCompilationButton = new System.Windows.Forms.Button();
            this.compilationTitleTextBox = new System.Windows.Forms.TextBox();
            this.compilationYearTextBox = new System.Windows.Forms.TextBox();
            this.trackAlbumIdTextBox = new System.Windows.Forms.TextBox();
            this.trackTitleTextBox = new System.Windows.Forms.TextBox();
            this.trackGenreTextBox = new System.Windows.Forms.TextBox();
            this.addTrackButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.addTrackToCompilationButton = new System.Windows.Forms.Button();
            resultsListBox.Cursor = Cursors.Hand; 
            this.resultsListBox.Click += new System.EventHandler(this.resultsListBox_Click);


            this.SuspendLayout();

            this.addArtistButton.Location = new System.Drawing.Point(20, 100);
            this.addArtistButton.Name = "addArtistButton";
            this.addArtistButton.Size = new System.Drawing.Size(120, 23);
            this.addArtistButton.TabIndex = 0;
            this.addArtistButton.Text = "Добавить исполнителя";
            this.addArtistButton.UseVisualStyleBackColor = true;
            this.addArtistButton.Click += new System.EventHandler(this.addArtistButton_Click);

            this.artistNameTextBox.Location = new System.Drawing.Point(20, 20);
            this.artistNameTextBox.Name = "artistNameTextBox";
            this.artistNameTextBox.PlaceholderText = "Имя исполнителя";
            this.artistNameTextBox.Size = new System.Drawing.Size(200, 23);

            this.artistGenreTextBox.Location = new System.Drawing.Point(20, 60);
            this.artistGenreTextBox.Name = "artistGenreTextBox";
            this.artistGenreTextBox.PlaceholderText = "Жанр исполнителя";
            this.artistGenreTextBox.Size = new System.Drawing.Size(200, 23);

            this.addAlbumButton.Location = new System.Drawing.Point(260, 100);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(120, 23);
            this.addAlbumButton.TabIndex = 1;
            this.addAlbumButton.Text = "Добавить альбом";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.addAlbumButton_Click);

            this.albumTitleTextBox.Location = new System.Drawing.Point(260, 20);
            this.albumTitleTextBox.Name = "albumTitleTextBox";
            this.albumTitleTextBox.PlaceholderText = "Название альбома";
            this.albumTitleTextBox.Size = new System.Drawing.Size(200, 23);

            this.albumYearTextBox.Location = new System.Drawing.Point(260, 60);
            this.albumYearTextBox.Name = "albumYearTextBox";
            this.albumYearTextBox.PlaceholderText = "Год выпуска";
            this.albumYearTextBox.Size = new System.Drawing.Size(80, 23);

            this.albumArtistIdTextBox.Location = new System.Drawing.Point(350, 60);
            this.albumArtistIdTextBox.Name = "albumArtistIdTextBox";
            this.albumArtistIdTextBox.PlaceholderText = "ID исполнителя";
            this.albumArtistIdTextBox.Size = new System.Drawing.Size(80, 23);

            this.addCompilationButton.Location = new System.Drawing.Point(500, 100);
            this.addCompilationButton.Name = "addCompilationButton";
            this.addCompilationButton.Size = new System.Drawing.Size(120, 23);
            this.addCompilationButton.TabIndex = 2;
            this.addCompilationButton.Text = "Добавить сборник";
            this.addCompilationButton.UseVisualStyleBackColor = true;
            this.addCompilationButton.Click += new System.EventHandler(this.addCompilationButton_Click);

            this.compilationTitleTextBox.Location = new System.Drawing.Point(500, 20);
            this.compilationTitleTextBox.Name = "compilationTitleTextBox";
            this.compilationTitleTextBox.PlaceholderText = "Название сборника";
            this.compilationTitleTextBox.Size = new System.Drawing.Size(200, 23);

            this.compilationYearTextBox.Location = new System.Drawing.Point(500, 60);
            this.compilationYearTextBox.Name = "compilationYearTextBox";
            this.compilationYearTextBox.PlaceholderText = "Год выпуска";
            this.compilationYearTextBox.Size = new System.Drawing.Size(80, 23);

            this.trackAlbumIdTextBox.Location = new System.Drawing.Point(740, 20); 
            this.trackAlbumIdTextBox.Name = "trackAlbumIdTextBox";
            this.trackAlbumIdTextBox.PlaceholderText = "ID альбома";
            this.trackAlbumIdTextBox.Size = new System.Drawing.Size(80, 23);

            this.trackTitleTextBox.Location = new System.Drawing.Point(740, 60); 
            this.trackTitleTextBox.Name = "trackTitleTextBox";
            this.trackTitleTextBox.PlaceholderText = "Название трека";
            this.trackTitleTextBox.Size = new System.Drawing.Size(110, 23);

            this.trackGenreTextBox.Location = new System.Drawing.Point(860, 60); 
            this.trackGenreTextBox.Name = "trackGenreTextBox";
            this.trackGenreTextBox.PlaceholderText = "Жанр трека";
            this.trackGenreTextBox.Size = new System.Drawing.Size(100, 23);

            this.addTrackButton.Location = new System.Drawing.Point(740, 100);
            this.addTrackButton.Name = "addTrackButton";
            this.addTrackButton.Size = new System.Drawing.Size(120, 23);
            this.addTrackButton.Text = "Добавить трек";
            this.addTrackButton.UseVisualStyleBackColor = true;
            this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);


            this.searchButton.Location = new System.Drawing.Point(260, 200);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);

            this.searchTypeComboBox.Location = new System.Drawing.Point(20, 200);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(120, 23);

            this.searchTextBox.Location = new System.Drawing.Point(150, 200);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Введите запрос";
            this.searchTextBox.Size = new System.Drawing.Size(100, 23);

            this.resultsListBox.Location = new System.Drawing.Point(20, 240);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(700, 150);


            this.trackIdTextBox = new System.Windows.Forms.TextBox
            {
                Location = new System.Drawing.Point(740, 140), 
                Name = "trackIdTextBox",
                PlaceholderText = "ID трека",
                Size = new System.Drawing.Size(80, 23)
            };

            this.compilationIdTextBox = new System.Windows.Forms.TextBox
            {
                Location = new System.Drawing.Point(840, 140), 
                Name = "compilationIdTextBox",
                PlaceholderText = "ID сборника",
                Size = new System.Drawing.Size(80, 23)
            };

            this.addTrackToCompilationButton = new System.Windows.Forms.Button
            {
                Location = new System.Drawing.Point(740, 180), 
                Name = "addTrackToCompilationButton",
                Size = new System.Drawing.Size(140, 46),
                Text = "Добавить трек в сборник",
                UseVisualStyleBackColor = true
            };
            this.addTrackToCompilationButton.Click += new System.EventHandler(this.addTrackToCompilationButton_Click);

            this.Controls.Add(this.trackIdTextBox);
            this.Controls.Add(this.compilationIdTextBox);
            this.Controls.Add(this.addTrackToCompilationButton);
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.addArtistButton);
            this.Controls.Add(this.artistNameTextBox);
            this.Controls.Add(this.artistGenreTextBox);
            this.Controls.Add(this.addAlbumButton);
            this.Controls.Add(this.albumTitleTextBox);
            this.Controls.Add(this.albumYearTextBox);
            this.Controls.Add(this.albumArtistIdTextBox);
            this.Controls.Add(this.addCompilationButton);
            this.Controls.Add(this.compilationTitleTextBox);
            this.Controls.Add(this.compilationYearTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTypeComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.trackAlbumIdTextBox); 
            this.Controls.Add(this.trackTitleTextBox);   
            this.Controls.Add(this.trackGenreTextBox);  
            this.Controls.Add(this.addTrackButton);      


            this.Text = "Музыкальный каталог";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addArtistButton;
        private System.Windows.Forms.TextBox artistNameTextBox;
        private System.Windows.Forms.TextBox artistGenreTextBox;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.TextBox albumTitleTextBox;
        private System.Windows.Forms.TextBox albumYearTextBox;
        private System.Windows.Forms.TextBox albumArtistIdTextBox;
        private System.Windows.Forms.Button addCompilationButton;
        private System.Windows.Forms.TextBox compilationTitleTextBox;
        private System.Windows.Forms.TextBox compilationYearTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox resultsListBox;

        private System.Windows.Forms.TextBox trackAlbumIdTextBox;
        private System.Windows.Forms.TextBox trackTitleTextBox;
        private System.Windows.Forms.TextBox trackGenreTextBox;
        private System.Windows.Forms.Button addTrackButton;
        private System.Windows.Forms.TextBox trackIdTextBox;
        private System.Windows.Forms.TextBox compilationIdTextBox;
        private System.Windows.Forms.Button addTrackToCompilationButton;
        private ISearchStrategy _searchStrategy;
    }
}
