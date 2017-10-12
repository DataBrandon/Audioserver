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
            this.addASongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllSongList = new System.Windows.Forms.ListView();
            this.SongName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.NameCurrentSongLabel = new System.Windows.Forms.Label();
            this.ServerStatus = new System.Windows.Forms.Label();
            this.CurrentPlayListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playlistserver = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(928, 28);
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
            this.PlayMenuItem.Size = new System.Drawing.Size(63, 24);
            this.PlayMenuItem.Text = "Media";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
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
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // toevoegenToolStripMenuItem
            // 
            this.toevoegenToolStripMenuItem.Name = "toevoegenToolStripMenuItem";
            this.toevoegenToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.toevoegenToolStripMenuItem.Text = "Create";
            this.toevoegenToolStripMenuItem.Click += new System.EventHandler(this.toevoegenToolStripMenuItem_Click);
            // 
            // importerenToolStripMenuItem
            // 
            this.importerenToolStripMenuItem.Name = "importerenToolStripMenuItem";
            this.importerenToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.importerenToolStripMenuItem.Text = "Open";
            this.importerenToolStripMenuItem.Click += new System.EventHandler(this.importerenToolStripMenuItem_Click);
            // 
            // exporterenToolStripMenuItem
            // 
            this.exporterenToolStripMenuItem.Name = "exporterenToolStripMenuItem";
            this.exporterenToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.exporterenToolStripMenuItem.Text = "Save";
            this.exporterenToolStripMenuItem.Click += new System.EventHandler(this.exporterenToolStripMenuItem_Click);
            // 
            // refreshSongListToolStripMenuItem
            // 
            this.refreshSongListToolStripMenuItem.Name = "refreshSongListToolStripMenuItem";
            this.refreshSongListToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.refreshSongListToolStripMenuItem.Text = "Refresh server media";
            this.refreshSongListToolStripMenuItem.Click += new System.EventHandler(this.refreshSongListToolStripMenuItem_Click);
            // 
            // sendListToServerToolStripMenuItem
            // 
            this.sendListToServerToolStripMenuItem.Name = "sendListToServerToolStripMenuItem";
            this.sendListToServerToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.sendListToServerToolStripMenuItem.Text = "Send to server";
            this.sendListToServerToolStripMenuItem.Click += new System.EventHandler(this.sendListToServerToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verbindToolStripMenuItem,
            this.verbreekVerbindingToolStripMenuItem,
            this.addASongToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // verbindToolStripMenuItem
            // 
            this.verbindToolStripMenuItem.Name = "verbindToolStripMenuItem";
            this.verbindToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.verbindToolStripMenuItem.Text = "Connect to server";
            this.verbindToolStripMenuItem.Click += new System.EventHandler(this.verbindToolStripMenuItem_Click);
            // 
            // verbreekVerbindingToolStripMenuItem
            // 
            this.verbreekVerbindingToolStripMenuItem.Name = "verbreekVerbindingToolStripMenuItem";
            this.verbreekVerbindingToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.verbreekVerbindingToolStripMenuItem.Text = "Disconnect from server";
            this.verbreekVerbindingToolStripMenuItem.Click += new System.EventHandler(this.verbreekVerbindingToolStripMenuItem_Click);
            // 
            // addASongToolStripMenuItem
            // 
            this.addASongToolStripMenuItem.Name = "addASongToolStripMenuItem";
            this.addASongToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.addASongToolStripMenuItem.Text = "Add a media file";
            this.addASongToolStripMenuItem.Click += new System.EventHandler(this.addASongToolStripMenuItem_Click);
            // 
            // AllSongList
            // 
            this.AllSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SongName});
            this.AllSongList.FullRowSelect = true;
            this.AllSongList.Location = new System.Drawing.Point(323, 72);
            this.AllSongList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllSongList.Name = "AllSongList";
            this.AllSongList.Size = new System.Drawing.Size(201, 208);
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
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current media:";
            // 
            // NameCurrentSongLabel
            // 
            this.NameCurrentSongLabel.AutoSize = true;
            this.NameCurrentSongLabel.Location = new System.Drawing.Point(15, 85);
            this.NameCurrentSongLabel.Name = "NameCurrentSongLabel";
            this.NameCurrentSongLabel.Size = new System.Drawing.Size(0, 17);
            this.NameCurrentSongLabel.TabIndex = 3;
            // 
            // ServerStatus
            // 
            this.ServerStatus.AutoSize = true;
            this.ServerStatus.Location = new System.Drawing.Point(323, 293);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(100, 17);
            this.ServerStatus.TabIndex = 4;
            this.ServerStatus.Text = "Not connected";
            // 
            // CurrentPlayListView
            // 
            this.CurrentPlayListView.AllowDrop = true;
            this.CurrentPlayListView.Enabled = false;
            this.CurrentPlayListView.Location = new System.Drawing.Point(532, 72);
            this.CurrentPlayListView.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentPlayListView.Name = "CurrentPlayListView";
            this.CurrentPlayListView.Size = new System.Drawing.Size(187, 208);
            this.CurrentPlayListView.TabIndex = 5;
            this.CurrentPlayListView.UseCompatibleStateImageBehavior = false;
            this.CurrentPlayListView.View = System.Windows.Forms.View.List;
            this.CurrentPlayListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CurrentPlayListView_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Media files on Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "PlayList to create";
            // 
            // playlistserver
            // 
            this.playlistserver.Location = new System.Drawing.Point(727, 72);
            this.playlistserver.Name = "playlistserver";
            this.playlistserver.Size = new System.Drawing.Size(182, 208);
            this.playlistserver.TabIndex = 8;
            this.playlistserver.UseCompatibleStateImageBehavior = false;
            this.playlistserver.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current playlist on server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 10;
            // 
            // ClientGui
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 319);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playlistserver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentPlayListView);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.NameCurrentSongLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllSongList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ListView playlistserver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

