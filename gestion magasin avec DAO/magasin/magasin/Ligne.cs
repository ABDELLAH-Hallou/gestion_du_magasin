using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    public class Ligne
    {
        public String idCommande { get; set; }
        public String idArticle { get; set; }
        public String quantite { get; set; }
        public Ligne() { }
        public Ligne(String idCommande, String idArticle, String quantite)
        {
            this.idCommande = idCommande;
            this.idArticle = idArticle;
            this.quantite = quantite;
        }
    }
}
