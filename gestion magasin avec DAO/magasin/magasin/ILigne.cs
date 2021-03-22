using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    public interface ILigne
    {
        void Add(Ligne ligne);
        void Delete(int idCommande, String idArticle, int position);
        void Update(Ligne ligne);
        void Show();
    }
}
