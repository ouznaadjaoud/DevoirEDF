using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetEDFWPF;

namespace ProjetEDFWPF
{
    public class somme
    {
        public int identifiant { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public int ancienReleve { get; set; }
        public int dernierReleve { get; set; }

        public int sum { get; set; }

        public somme(int unId, string unNom, string unPrenom, int unAncienR, int unDernierR)
        {
            identifiant = unId;
            nom = unNom;
            prenom = unPrenom;
            ancienReleve = unAncienR;
            dernierReleve = unDernierR;
            sum = unDernierR - unAncienR;
        }
    }

   

}
