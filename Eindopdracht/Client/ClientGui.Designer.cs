namespace Client
{
    partial class ClientGui
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
            this.PlayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshSongListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendListToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verbindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verbreekVerbindingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllSongList = new System.Windows.Forms.ListView();
            this.SongName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.NameCurrentSongLabel = new System.Windows.Forms.Label();
            this.ServerStatus = new System.Windows.Forms.Label();
            this.CurrentPlayListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addASongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayMenuItem,
            this.playlistToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PlayMenuItem
            // 
            this.PlayMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem});
            this.PlayMenuItem.Name = "PlayMenuItem";
            this.PlayMenuItem.Size = new System.Drawing.Size(52, 20);
            this.PlayMenuItem.Text = "Media";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toevoegenToolStripMenuItem,
            this.importerenToolStripMenuItem,
            this.exporterenToolStripMenuItem,
            this.refreshSongListToolStripMenuItem,
            this.sendListToServerToolStripMenuItem});
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // toevoegenToolStripMenuItem
            // 
            this.toevoegenToolStripMenuItem.Name = "toevoegenToolStripMenuItem";
            this.toevoegenToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.toevoegenToolStripMenuItem.Text = "Nieuwe Maken";
            this.toevoegenToolStripMenuItem.Click += new System.EventHandler(this.toevoegenToolStripMenuItem_Click);
            // 
            // importerenToolStripMenuItem
            // 
            this.importerenToolStripMenuItem.Name = "importerenToolStripMenuItem";
            this.importerenToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.importerenToolStripMenuItem.Text = "Openen";
            this.importerenToolStripMenuItem.Click += new System.EventHandler(this.importerenToolStripMenuItem_Click);
            // 
            // exporterenToolStripMenuItem
            // 
            this.exporterenToolStripMenuItem.Name = "exporterenToolStripMenuItem";
            this.exporterenToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exporterenToolStripMenuItem.Text = "Opslaan";
            this.exporterenToolStripMenuItem.Click += new System.EventHandler(this.exporterenToolStripMenuItem_Click);
            // 
            // refreshSongListToolStripMenuItem
            // 
            this.refreshSongListToolStripMenuItem.Name = "refreshSongListToolStripMenuItem";
            this.refreshSongListToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.refreshSongListToolStripMenuItem.Text = "Refresh Server Media";
            this.refreshSongListToolStripMenuItem.Click += new System.EventHandler(this.refreshSongListToolStripMenuItem_Click);
            // 
            // sendListToServerToolStripMenuItem
            // 
            this.sendListToServerToolStripMenuItem.Name = "sendListToServerToolStripMenuItem";
            this.sendListToServerToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sendListToServerToolStripMenuItem.Text = "Naar server versturen";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verbindToolStripMenuItem,
            this.verbreekVerbindingToolStripMenuItem,
            this.addASongToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // verbindToolStripMenuItem
            // 
            this.verbindToolStripMenuItem.Name = "verbindToolStripMenuItem";
            this.verbindToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.verbindToolStripMenuItem.Text = "Verbind";
            this.verbindToolStripMenuItem.Click += new System.EventHandler(this.verbindToolStripMenuItem_Click);
            // 
            // verbreekVerbindingToolStripMenuItem
            // 
            this.verbreekVerbindingToolStripMenuItem.Name = "verbreekVerbindingToolStripMenuItem";
            this.verbreekVerbindingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.verbreekVerbindingToolStripMenuItem.Text = "Verbreek verbinding";
            this.verbreekVerbindingToolStripMenuItem.Click += new System.EventHandler(this.verbreekVerbindingToolStripMenuItem_Click);
            // 
            // AllSongList
            // 
            this.AllSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SongName});
            this.AllSongList.FullRowSelect = true;
            this.AllSongList.Location = new System.Drawing.Point(131, 53);
            this.AllSongList.Margin = new System.Windows.Forms.Padding(2);
            this.AllSongList.Name = "AllSongList";
            this.AllSongList.Size = new System.Drawing.Size(152, 170);
            this.AllSongList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.AllSongList.TabIndex = 1;
            this.AllSongList.UseCompatibleStateImageBehavior = false;
            this.AllSongList.View = System.Windows.Forms.View.List;
            this.AllSongList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AllSongList_MouseDoubleClick);
            // 
            // SongName
            // 
            this.SongName.Text = "Song name";
            this.SongName.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current:";
            // 
            // NameCurrentSongLabel
            // 
            this.NameCurrentSongLabel.AutoSize = true;
            this.NameCurrentSongLabel.Location = new System.Drawing.Point(11, 69);
            this.NameCurrentSongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameCurrentSongLabel.Name = "NameCurrentSongLabel";
            this.NameCurrentSongLabel.Size = new System.Drawing.Size(0, 13);
            this.NameCurrentSongLabel.TabIndex = 3;
            // 
            // ServerStatus
            // 
            this.ServerStatus.AutoSize = true;
            this.ServerStatus.Location = new System.Drawing.Point(205, 237);
            this.ServerStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(78, 13);
            this.ServerStatus.TabIndex = 4;
            this.ServerStatus.Text = "Not connected";
            // 
            // CurrentPlayListView
            // 
            this.CurrentPlayListView.AllowDrop = true;
            this.CurrentPlayListView.Enabled = false;
            this.CurrentPlayListView.Location = new System.Drawing.Point(288, 53);
            this.CurrentPlayListView.Name = "CurrentPlayListView";
            this.CurrentPlayListView.Size = new System.Drawing.Size(141, 170);
            this.CurrentPlayListView.TabIndex = 5;
            this.CurrentPlayListView.UseCompatibleStateImageBehavior = false;
            this.CurrentPlayListView.View = System.Windows.Forms.View.List;
            this.CurrentPlayListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CurrentPlayListView_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nummers op Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Te maken PlayList";
            // addASongToolStripMenuItem
            // 
            this.addASongToolStripMenuItem.Name = "addASongToolStripMenuItem";
            this.addASongToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.addASongToolStripMenuItem.Text = "Add a song";
            this.addASongToolStripMenuItem.Click += new System.EventHandler(this.addASongToolStripMenuItem_Click);
            // 
            // ClientGui
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 259);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentPlayListView);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.NameCurrentSongLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllSongList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientGui";
            this.Text = "ClientGui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientGui_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PlayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toevoegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verbindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verbreekVerbindingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshSongListToolStripMenuItem;
        private System.Windows.Forms.ListView AllSongList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameCurrentSongLabel;
        private System.Windows.Forms.ColumnHeader SongName;
        private System.Windows.Forms.Label ServerStatus;
        private System.Windows.Forms.ListView CurrentPlayListView;
        private System.Windows.Forms.ToolStripMenuItem sendListToServerToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem addASongToolStripMenuItem;
    }
}

