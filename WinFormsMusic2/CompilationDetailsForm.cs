using System.Windows.Forms;

namespace WinFormsMusic2
{
    partial class CompilationDetailsForm
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
            this.compilationTitleLabel = new Label();
            this.compilationYearLabel = new Label();
            this.tracksListBox = new ListBox();

            this.compilationTitleLabel.AutoSize = true;
            this.compilationTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.compilationTitleLabel.Text = "Название сборника";

            this.tracksListBox.Location = new System.Drawing.Point(20, 80);
            this.tracksListBox.Size = new System.Drawing.Size(200, 150);

            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.compilationTitleLabel);
            this.Controls.Add(this.tracksListBox);
            this.Text = "Информация о сборнике";
        }

        private Label compilationTitleLabel;
        private ListBox tracksListBox;
        private Label compilationYearLabel;
        private ListBox artistsListBox;

    }
}
