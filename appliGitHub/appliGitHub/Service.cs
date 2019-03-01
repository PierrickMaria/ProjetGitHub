using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appliGitHub
{
    class Service
    {
        private int id;
        private string libelle;


        public  Service(int pid, string plibelle)
        {
            this.id = pid;
            this.libelle = plibelle;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetLibelle()
        {
            return this.libelle;
        }

        public void SetLibelle(string libellee)
        {
            this.libelle = libellee;
        }
    }
}
