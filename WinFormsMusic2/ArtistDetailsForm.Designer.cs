using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsMusic2.Models;
using WinFormsMusic2.Services;
namespace WinFormsMusic2
{

    partial class ArtistDetailsForm
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
            this.artistNameLabel = new System.Windows.Forms.Label();
            this.artistTracksLabel = new System.Windows.Forms.Label();
            this.artistAlbumsLabel = new System.Windows.Forms.Label();
            this.artistGenreLabel = new System.Windows.Forms.Label();
            this.albumsListBox = new System.Windows.Forms.ListBox();
            this.tracksListBox = new System.Windows.Forms.ListBox();

            this.artistNameLabel.AutoSize = true;
            this.artistNameLabel.Location = new System.Drawing.Point(20, 20);
            this.artistNameLabel.Name = "artistNameLabel";
            this.artistNameLabel.Size = new System.Drawing.Size(120, 15); 
            this.artistNameLabel.Text = "Имя исполнителя";

            this.artistGenreLabel.AutoSize = true;
            this.artistGenreLabel.Location = new System.Drawing.Point(20, 50);
            this.artistGenreLabel.Name = "artistGenreLabel";
            this.artistGenreLabel.Size = new System.Drawing.Size(38, 15); 
            this.artistGenreLabel.Text = "Жанр";

            this.artistTracksLabel.AutoSize = true;
            this.artistTracksLabel.Location = new System.Drawing.Point(250, 80);
            this.artistTracksLabel.Name = "artistTracksLabel";
            this.artistTracksLabel.Size = new System.Drawing.Size(38, 15);
            this.artistTracksLabel.Text = "Альбомы";

            this.artistAlbumsLabel.AutoSize = true;
            this.artistAlbumsLabel.Location = new System.Drawing.Point(20, 80);
            this.artistAlbumsLabel.Name = "artistAlbumsLabel";
            this.artistAlbumsLabel.Size = new System.Drawing.Size(38, 15);
            this.artistAlbumsLabel.Text = "Треки";

            this.albumsListBox.Location = new System.Drawing.Point(20, 100);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(200, 150);

            this.tracksListBox.Location = new System.Drawing.Point(250, 100);
            this.tracksListBox.Name = "tracksListBox";
            this.tracksListBox.Size = new System.Drawing.Size(200, 150);

            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.artistNameLabel);
            this.Controls.Add(this.artistGenreLabel);
            this.Controls.Add(this.artistTracksLabel);
            this.Controls.Add(this.artistAlbumsLabel);
            this.Controls.Add(this.albumsListBox);
            this.Controls.Add(this.tracksListBox);
            this.Text = "Информация об исполнителе";
        }

        private System.Windows.Forms.Label artistAlbumsLabel;
        private System.Windows.Forms.Label artistTracksLabel;
        private System.Windows.Forms.Label artistNameLabel;
        private System.Windows.Forms.Label artistGenreLabel;
        private System.Windows.Forms.ListBox albumsListBox;
        private System.Windows.Forms.ListBox tracksListBox;
    }
}