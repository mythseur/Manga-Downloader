﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO : Finish the interface

namespace MangaDownloader
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Config.loadConfig();

            if(this.listBox1.Items.Count > 0)
                this.listBox1.SetSelected(0, true);
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {

        }

        private void préférencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PreferencesWindow preferencesWindow = new PreferencesWindow();

            preferencesWindow.ShowDialog();
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void epubToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterDesPluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aProposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AProposWindow aProposWindow = new AProposWindow();

            aProposWindow.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddWindow addWindow = new AddWindow();

            if(addWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.listBox1.Items.Add(addWindow.MangaName);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;

            if (this.listBox1.SelectedItem != null)
            {
                selectedIndex = this.listBox1.SelectedIndex;
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);

                if(!(selectedIndex < this.listBox1.Items.Count))
                {
                    selectedIndex--;

                }

                if(this.listBox1.Items.Count > 0)
                    this.listBox1.SetSelected(selectedIndex, true);
            }
        }

        private void sitesSupportésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}