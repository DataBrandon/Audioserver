namespace Eindopdracht
{
    partial class MediaPlayerForm
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
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMediaLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.mediaLocationToolStripMenuItem,
            this.playListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // mediaLocationToolStripMenuItem
            // 
            this.mediaLocationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeMediaLocationToolStripMenuItem});
            this.mediaLocationToolStripMenuItem.Name = "mediaLocationToolStripMenuItem";
            this.mediaLocationToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mediaLocationToolStripMenuItem.Text = "Media Location";
            // 
            // changeMediaLocationToolStripMenuItem
            // 
            this.changeMediaLocationToolStripMenuItem.Name = "changeMediaLocationToolStripMenuItem";
            this.changeMediaLocationToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.changeMediaLocationToolStripMenuItem.Text = "Change Media Location";
            // 
            // playListToolStripMenuItem
            // 
            this.playListToolStripMenuItem.Name = "playListToolStripMenuItem";
            this.playListToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.playListToolStripMenuItem.Text = "PlayList";
            // 
            // MediaPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 227);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MediaPlayerForm";
            this.Text = "MediaPlayerForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMediaLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playListToolStripMenuItem;
    }
}