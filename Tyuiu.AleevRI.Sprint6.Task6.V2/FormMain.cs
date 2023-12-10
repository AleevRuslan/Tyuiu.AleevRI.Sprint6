using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.AleevRI.Sprint6.Task6.V2.Lib;

namespace Tyuiu.AleevRI.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;

        private void buttonLoadFile_ARI_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            openFilePath = openFileDialog.FileName;
            textBoxInPut_ARI.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_ARI.Text = groupBoxOutPut_ARI.Text + " " + openFileDialog.FileName;
            buttonDone_ARI.Enabled = true;
        }

        private void buttonHelp_ARI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_ARI_Click(object sender, EventArgs e)
        {
            textBoxOutPut_ARI.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
