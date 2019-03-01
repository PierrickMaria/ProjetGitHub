using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appliGitHub
{
    class Employe
    {
        private int id;
        private string nom;
        private string prenom;
        private string adresse;
        private int tel;

        public Employe(int pid, string pnom, string pprenom, string padr, int ptel)
        {
            this.id = pid;
            this.nom = pnom;
            this.prenom = pprenom;
            this.adresse = padr;
            this.tel = ptel;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public string GetPrenom()
        {
            return this.prenom;
        }

        public string ToString()
        {
            return "Identifiant : " + this.id + "\n Nom : " + this.nom + "\n Prénom : " + this.prenom + "\n Adresse : " + this.adresse + "\n Tél : " + this.tel;
        }
    }
}
