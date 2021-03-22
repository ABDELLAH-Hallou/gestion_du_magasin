using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    public class Commande
    {
        public String idCommande { get; set; }
        public String date { get; set; }
        public String idClient { get; set; }
        public Commande() { }
        public Commande(String idCommande, String date, String idClient)
        {
            this.idClient = idClient;
            this.idCommande = idCommande;
            this.date = date;
        }
        public Commande(String date, String idClient)
        {
            this.date = date;
            this.idClient = idClient;
        }
    }
}
