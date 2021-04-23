using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;

namespace Insurance.BLL.Interfaces
{
    public interface IReasonService
    {
        Task Create(Reason reason);
        Task<IEnumerable<Reason>> Get();
        Task<Reason> GetById(int id);
        Task Update(Reason reason, int id);
        Task Delete(int id);
    }
}