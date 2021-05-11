using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Front_endTemplate.DTO;
using Microsoft.AspNetCore.Components;

namespace Front_endTemplate.Services
{
    public class ContractService:IContractService
    {
        private  HttpClient _httpClient;
       

        public ContractService()
        {
            _httpClient = new HttpClient();
        }

        public async Task Create(ContractDTO contract)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:8080/api/v1/Contract", contract);
            
        }
    }
}