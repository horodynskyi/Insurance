using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;

namespace Insurance.BLL.Interfaces
{
    public interface ITariffService
    {
        Task Create(Tariff tariff);
        Task<IEnumerable<Tariff>> Get(GenericParams parameters);
        Task<Tariff> GetById(int id);
        Task Update(Tariff tariff, int id);
        Task Delete(int id);
    }
}