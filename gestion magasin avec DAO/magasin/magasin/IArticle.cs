using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    public interface IArticle
    {
        void Add(Article article);
        void Delete(String idArticle, int position);
        void Update(Article article);
        void Show();
    }
}
