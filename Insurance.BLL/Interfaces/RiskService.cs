using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;

namespace Insurance.BLL.Interfaces
{
    public interface IRiskService
    {
        Task Create(Risk risk);
        Task<IEnumerable<Risk>> Get();
        Task<Risk> GetById(int id);
        Task Update(Risk risk, int id);
        Task Delete(int id);
    }
}