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
    public partial class FsaisieService : Form
    {
        public FsaisieService()
        {
            InitializeComponent();
        }

        private void FsaisieService_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            var newService = new Service(int.Parse(txt_id.Text), txt_libelle.Text);
            MessageBox.Show("Service ajouté avec succès : " + newService.ToString());

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
