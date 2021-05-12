using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;

namespace Insurance.BLL.Interfaces
{
    public interface IRiskService
    {
        Task Create(Risk risk);
        Task<IEnumerable<Risk>> Get(GenericParams parameters);
        Task<Risk> GetById(int id);
        Task Update(Risk risk, int id);
        Task Delete(int id);
    }
}