using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    public class Client
    {
        public String idClient { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public String age { get; set; }
        public String adresse { get; set; }
        public String ville { get; set; }
        public String specialite { get; set; }
        public String mail { get; set; }
        public Client() { }
        public Client(String idClient, String nom, String prenom, String age, String adresse, String ville, String specialite, String mail) 
        {
            this.idClient = idClient;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adresse = adresse;
            this.ville = ville;
            this.specialite = specialite;
            this.mail = mail;
        }
        public Client(String nom, String prenom, String age, String adresse, String ville, String specialite, String mail)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adresse = adresse;
            this.ville = ville;
            this.specialite = specialite;
            this.mail = mail;
        }
    }
}
