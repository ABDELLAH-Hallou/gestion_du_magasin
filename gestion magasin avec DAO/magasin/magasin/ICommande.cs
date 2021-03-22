using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    public interface ICommande
    {
        void Add(Commande commande);
        void Delete(int idCommande, int position);
        void Update(Commande commande);
        void Show();
    }
}
