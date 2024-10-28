using WinFormsMusic2.Services;
using WinFormsMusic2.Models;

namespace WinFormsMusic2
{
    partial class TrackDetailsForm
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
            this.trackTitleLabel = new Label();
            this.trackGenreLabel = new Label();
            this.trackAlbumLabel = new Label();
            this.trackArtistLabel = new Label();

            this.trackTitleLabel.AutoSize = true;
            this.trackTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.trackTitleLabel.Text = "Название трека";

            this.trackArtistLabel.AutoSize = true;
            this.trackArtistLabel.Location = new System.Drawing.Point(20, 50);
            this.trackArtistLabel.Text = "Исполнитель";

            this.trackAlbumLabel.AutoSize = true;
            this.trackAlbumLabel.Location = new System.Drawing.Point(20, 80);
            this.trackAlbumLabel.Text = "Альбом";

            this.trackGenreLabel.AutoSize = true;
            this.trackGenreLabel.Location = new System.Drawing.Point(20, 110);
            this.trackGenreLabel.Text = "Жанр";

            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.trackTitleLabel);
            this.Controls.Add(this.trackArtistLabel);
            this.Controls.Add(this.trackAlbumLabel);
            this.Controls.Add(this.trackGenreLabel);
            this.Text = "Информация о треке";
        }

        private Label trackTitleLabel;
        private Label trackArtistLabel;
        private Label trackAlbumLabel;
        private Label trackGenreLabel;
       
    }
}