using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magasin
{
    public interface IClient
    {
            void Add(Client client);
            void Delete(int idClient,int position);
            void Update(Client client);
            void Show();
    }
}
