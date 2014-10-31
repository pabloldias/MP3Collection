using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace MP3Collection
{
    public partial class frmMain : Form
    {
        private AlbumController albumController = 
            new AlbumController(@"..\..\data\albuns.xml");

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            albumController.deserialize();
            grdAlbums.DataSource = albumController.getList(); 

            txtFind.Focus();
            cmbFindType.SelectedIndex = 0;
            lblCount.Text = albumController.getCount() + " albums";
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgFolder.ShowDialog();
            lblFolder.Text = "";
            albumBindingSource.DataSource = null;
            if (result == DialogResult.OK)
            {
                lblFolder.Text = dlgFolder.SelectedPath;
                albumBindingSource.DataSource = albumController.getListFromDir(dlgFolder.SelectedPath, txtDVD.Text);
            }
            else
            {
                txtDVD.Text = "";
            }
        }        

        private void txtDVD_TextChanged(object sender, EventArgs e)
        {
            bool canImport = txtDVD.Text != "";
            btnFolder.Enabled = canImport;
            grdAlbumsImport.Enabled = canImport;
            btnImport.Enabled = canImport;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            filterChange();
        }

        private void cmbFindType_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterChange();
        }

        private void filterChange()
        { 
            grdAlbums.DataSource = albumController.filterAlbums(txtFind.Text, cmbFindType.SelectedIndex);
            lblCount.Text = ((List<Album>)grdAlbums.DataSource).Count + " albums";
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            filterKeyDown(e);
        }

        private void grdAlbums_KeyDown(object sender, KeyEventArgs e)
        {
            filterKeyDown(e);
        }

        private void filterKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (txtFind.Focused)
                    grdAlbums.Focus();
                else                
                    txtFind.Focus();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            albumController.mergeLists();
            grdAlbums.DataSource = albumController.getList();
            lblCount.Text = albumController.getCount() + " albums";
            tabControl.SelectTab(tabAlbums);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            albumController.serialize();
        }
    }
}
