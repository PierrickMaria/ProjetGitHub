using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appliGitHub
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormNom = new FsaisieEmploye();
            FormNom.Show();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormSaisie = new FsaisieService();
            FormSaisie.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
