using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMVVM.Models
{
    internal class Livre
    {
        public int Id_Livre { get; set; }
        public string ISBN { get; set; }
        public string Titre_livre { get; set; }
        public string Theme_livre { get; set; }
        public int Nbr_pages_livre { get; set; }
        public string Format_livre { get; set; }
        public string Nom_auteur { get; set; }
        public string Prenom_auteur { get; set; }
        public string Editeur { get; set; }
        public int Annee_edition { get; set; }
        public float Prix_vente { get; set; }
        public string Langue_livre { get; set; }
    }
}
