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
    public partial class FsaisieEmploye : Form
    {
        public FsaisieEmploye()
        {
            InitializeComponent();
        }

        private void buttonValide_Click(object sender, EventArgs e)
        {
            var newEmploye = new Employe(textBoxNom.Text ,textBoxPrenom.Text);
            MessageBox.Show("Employé ajouté : " + newEmploye.ToString());
        }
    }
}
