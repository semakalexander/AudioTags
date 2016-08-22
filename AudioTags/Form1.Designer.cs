namespace AudioTags
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewAudioFiles = new System.Windows.Forms.DataGridView();
            this.richTextBoxErrorSongs = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelSelectDowloadSong = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudioFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirectoryToolStripMenuItem,
            this.openFileToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openDirectoryToolStripMenuItem.Text = "Open Directory";
            this.openDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // dataGridViewAudioFiles
            // 
            this.dataGridViewAudioFiles.AllowUserToAddRows = false;
            this.dataGridViewAudioFiles.AllowUserToDeleteRows = false;
            this.dataGridViewAudioFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAudioFiles.Location = new System.Drawing.Point(0, 27);
            this.dataGridViewAudioFiles.Name = "dataGridViewAudioFiles";
            this.dataGridViewAudioFiles.Size = new System.Drawing.Size(392, 317);
            this.dataGridViewAudioFiles.TabIndex = 1;
            // 
            // richTextBoxErrorSongs
            // 
            this.richTextBoxErrorSongs.Location = new System.Drawing.Point(398, 27);
            this.richTextBoxErrorSongs.Name = "richTextBoxErrorSongs";
            this.richTextBoxErrorSongs.Size = new System.Drawing.Size(261, 115);
            this.richTextBoxErrorSongs.TabIndex = 2;
            this.richTextBoxErrorSongs.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(398, 177);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(261, 35);
            this.progressBar.TabIndex = 3;
            // 
            // labelSelectDowloadSong
            // 
            this.labelSelectDowloadSong.AutoSize = true;
            this.labelSelectDowloadSong.Location = new System.Drawing.Point(399, 158);
            this.labelSelectDowloadSong.Name = "labelSelectDowloadSong";
            this.labelSelectDowloadSong.Size = new System.Drawing.Size(0, 13);
            this.labelSelectDowloadSong.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 468);
            this.Controls.Add(this.labelSelectDowloadSong);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.richTextBoxErrorSongs);
            this.Controls.Add(this.dataGridViewAudioFiles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudioFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewAudioFiles;
        private System.Windows.Forms.RichTextBox richTextBoxErrorSongs;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelSelectDowloadSong;
    }
}

