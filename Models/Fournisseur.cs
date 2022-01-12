using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMVVM.Models
{
    internal class Fournisseur
    {
        public int Id_fournisseur { get; set; }
        public string Code_fournisseur { get; set; }
        public string Raison_sociale { get; set; }
        public string Rue_fournisseur { get; set; }
        public string Code_postal { get; set; }
        public string Localite { get; set; }
        public string Pays { get; set; }
        public string Tel_fournisseur { get; set; }
        public string Url_fournisseur { get; set; }
        public string Email_fournisseur { get; set; }
        public string Fax_fournisseur { get; set; }
    }
}
