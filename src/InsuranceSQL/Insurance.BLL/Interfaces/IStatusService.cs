using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;

namespace Insurance.BLL.Interfaces
{
    public interface IStatusService
    {
        Task Create(Status status);
        Task<IEnumerable<Status>> Get(GenericParams parameters);
        Task<Status> GetById(int id);
        Task Update(Status status, int id);
        Task Delete(int id);
    }
}