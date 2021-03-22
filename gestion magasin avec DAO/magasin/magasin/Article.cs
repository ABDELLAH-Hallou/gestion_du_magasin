using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    public class Article
    {
        public String idArticle { get; set; }
        public String designation { get; set; }
        public String prix { get; set; }
        public String categorie { get; set; }
        public Article() { }
        public Article(String idArticle, String designation, String prix, String categorie)
        {
            this.idArticle = idArticle;
            this.designation = designation;
            this.prix = prix; 
            this.categorie = categorie;
        }
        public Article(String designation, String prix, String categorie)
        {
            this.designation = designation;
            this.prix = prix;
            this.categorie = categorie;
        }
    }
}
