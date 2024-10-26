using System.Windows.Forms;

namespace WinFormsMusic2
{
    partial class AlbumDetailsForm
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
            this.albumTitleLabel = new Label();
            this.albumGenreLabel = new Label();
            this.albumReleaseDateLabel = new Label();
            this.tracksListBox = new ListBox();
            this.albumArtistLabel = new Label(); // Инициализируем поле исполнителя

            this.albumTitleLabel.AutoSize = true;
            this.albumTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.albumTitleLabel.Text = "Название альбома";

            this.albumArtistLabel.AutoSize = true;
            this.albumArtistLabel.Location = new System.Drawing.Point(20, 50);
            this.albumArtistLabel.Text = "Исполнитель"; // Место для имени исполнителя

            this.albumReleaseDateLabel.AutoSize = true;
            this.albumReleaseDateLabel.Location = new System.Drawing.Point(20, 80);
            this.albumReleaseDateLabel.Text = "Дата выпуска";

            this.tracksListBox.Location = new System.Drawing.Point(20, 140);
            this.tracksListBox.Size = new System.Drawing.Size(200, 150);

            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.albumTitleLabel);
            this.Controls.Add(this.albumArtistLabel);
            this.Controls.Add(this.albumGenreLabel);
            this.Controls.Add(this.albumReleaseDateLabel);
            this.Controls.Add(this.tracksListBox);
            this.Text = "Информация об альбоме";
        }

        private Label albumTitleLabel;
        private Label albumGenreLabel;
        private Label albumArtistLabel;
        private Label albumReleaseDateLabel;
        private ListBox tracksListBox;
    }
}
