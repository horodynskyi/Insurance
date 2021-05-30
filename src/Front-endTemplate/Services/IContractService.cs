using System.Threading.Tasks;
using Front_endTemplate.DTO;

namespace Front_endTemplate.Services
{
    public interface IContractService
    {
        Task Create(ContractDTO contract);
    }
}