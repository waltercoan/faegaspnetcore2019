using System.Collections.Generic;
using System.Threading.Tasks;
using empresaapp.Models;

namespace empresaapp.Services
{
    public interface IClientService
    {
         Task<IList<Client>> GetAll();
         void Save(Client client);

         Task<Client> GetById(int id);
    }
}