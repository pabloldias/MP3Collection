namespace MP3Collection
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.cmbFindType = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.grdAlbums = new System.Windows.Forms.DataGridView();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.grdAlbumsImport = new System.Windows.Forms.DataGridView();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImport = new System.Windows.Forms.Button();
            this.lblDVD = new System.Windows.Forms.Label();
            this.txtDVD = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.tabAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlbums)).BeginInit();
            this.tabImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlbumsImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tabAlbums);
            this.tabControl.Controls.Add(this.tabImport);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(903, 451);
            this.tabControl.TabIndex = 0;
            // 
            // tabAlbums
            // 
            this.tabAlbums.Controls.Add(this.lblCount);
            this.tabAlbums.Controls.Add(this.cmbFindType);
            this.tabAlbums.Controls.Add(this.txtFind);
            this.tabAlbums.Controls.Add(this.grdAlbums);
            this.tabAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlbums.Size = new System.Drawing.Size(895, 422);
            this.tabAlbums.TabIndex = 0;
            this.tabAlbums.Text = "Albums";
            this.tabAlbums.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(407, 403);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 3;
            // 
            // cmbFindType
            // 
            this.cmbFindType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbFindType.FormattingEnabled = true;
            this.cmbFindType.Items.AddRange(new object[] {
            "Artist name",
            "Album name",
            "DVD"});
            this.cmbFindType.Location = new System.Drawing.Point(279, 398);
            this.cmbFindType.Name = "cmbFindType";
            this.cmbFindType.Size = new System.Drawing.Size(121, 21);
            this.cmbFindType.TabIndex = 2;
            this.cmbFindType.SelectedIndexChanged += new System.EventHandler(this.cmbFindType_SelectedIndexChanged);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFind.Location = new System.Drawing.Point(3, 398);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(270, 20);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // grdAlbums
            // 
            this.grdAlbums.AllowUserToOrderColumns = true;
            this.grdAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAlbums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlbums.Location = new System.Drawing.Point(3, 3);
            this.grdAlbums.Name = "grdAlbums";
            this.grdAlbums.RowHeadersWidth = 30;
            this.grdAlbums.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdAlbums.Size = new System.Drawing.Size(887, 384);
            this.grdAlbums.TabIndex = 0;
            this.grdAlbums.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdAlbums_KeyDown);
            // 
            // tabImport
            // 
            this.tabImport.Controls.Add(this.grdAlbumsImport);
            this.tabImport.Controls.Add(this.btnImport);
            this.tabImport.Controls.Add(this.lblDVD);
            this.tabImport.Controls.Add(this.txtDVD);
            this.tabImport.Controls.Add(this.lblFolder);
            this.tabImport.Controls.Add(this.btnFolder);
            this.tabImport.Location = new System.Drawing.Point(4, 25);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabImport.Size = new System.Drawing.Size(895, 422);
            this.tabImport.TabIndex = 1;
            this.tabImport.Text = "Import";
            this.tabImport.UseVisualStyleBackColor = true;
            // 
            // grdAlbumsImport
            // 
            this.grdAlbumsImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAlbumsImport.AutoGenerateColumns = false;
            this.grdAlbumsImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAlbumsImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlbumsImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistNameDataGridViewTextBoxColumn,
            this.albumNameDataGridViewTextBoxColumn,
            this.dVDDataGridViewTextBoxColumn});
            this.grdAlbumsImport.DataSource = this.albumBindingSource;
            this.grdAlbumsImport.Enabled = false;
            this.grdAlbumsImport.Location = new System.Drawing.Point(11, 35);
            this.grdAlbumsImport.Name = "grdAlbumsImport";
            this.grdAlbumsImport.Size = new System.Drawing.Size(878, 340);
            this.grdAlbumsImport.TabIndex = 2;
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.FillWeight = 2F;
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "Artist Name";
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            // 
            // albumNameDataGridViewTextBoxColumn
            // 
            this.albumNameDataGridViewTextBoxColumn.DataPropertyName = "AlbumName";
            this.albumNameDataGridViewTextBoxColumn.FillWeight = 2F;
            this.albumNameDataGridViewTextBoxColumn.HeaderText = "Album Name";
            this.albumNameDataGridViewTextBoxColumn.Name = "albumNameDataGridViewTextBoxColumn";
            // 
            // dVDDataGridViewTextBoxColumn
            // 
            this.dVDDataGridViewTextBoxColumn.DataPropertyName = "DVD";
            this.dVDDataGridViewTextBoxColumn.FillWeight = 1F;
            this.dVDDataGridViewTextBoxColumn.HeaderText = "DVD";
            this.dVDDataGridViewTextBoxColumn.Name = "dVDDataGridViewTextBoxColumn";
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(Album);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(11, 381);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(876, 33);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import folders";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblDVD
            // 
            this.lblDVD.AutoSize = true;
            this.lblDVD.Location = new System.Drawing.Point(8, 11);
            this.lblDVD.Name = "lblDVD";
            this.lblDVD.Size = new System.Drawing.Size(38, 13);
            this.lblDVD.TabIndex = 4;
            this.lblDVD.Text = "DVD:";
            // 
            // txtDVD
            // 
            this.txtDVD.Location = new System.Drawing.Point(52, 8);
            this.txtDVD.Name = "txtDVD";
            this.txtDVD.Size = new System.Drawing.Size(84, 20);
            this.txtDVD.TabIndex = 0;
            this.txtDVD.TextChanged += new System.EventHandler(this.txtDVD_TextChanged);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(290, 11);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(0, 13);
            this.lblFolder.TabIndex = 1;
            // 
            // btnFolder
            // 
            this.btnFolder.Enabled = false;
            this.btnFolder.Location = new System.Drawing.Point(142, 6);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(142, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Select folder...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // dlgFolder
            // 
            this.dlgFolder.SelectedPath = "C:\\mp3\\álbuns";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 451);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Verdana", 8F);
            this.Name = "frmMain";
            this.Text = "MP3 Collection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabAlbums.ResumeLayout(false);
            this.tabAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlbums)).EndInit();
            this.tabImport.ResumeLayout(false);
            this.tabImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlbumsImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAlbums;
        private System.Windows.Forms.TabPage tabImport;
        private System.Windows.Forms.DataGridView grdAlbums;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblDVD;
        private System.Windows.Forms.TextBox txtDVD;
        private System.Windows.Forms.DataGridView grdAlbumsImport;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbFindType;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblCount;
    }
}

