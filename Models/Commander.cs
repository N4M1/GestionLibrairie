using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMVVM.Models
{
    internal class Commander
    {
        public int Id_commande { get; set; }
        public int Id_Livre { get; set; }
        public int Id_fournisseur { get; set; }
        public DateTime Date_achat { get; set; }
        public decimal Prix_achat { get; set; }
        public int Nbr_exemplaires { get; set; }
    }
}
