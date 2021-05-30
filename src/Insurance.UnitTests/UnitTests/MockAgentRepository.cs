using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;
using Insurance.Repositories.Interfaces.IRepositories;
using Moq;

namespace Insurance.UnitTests
{
    public class MockAgentRepository:Mock<IAgentRepository>
    {
        public async Task<MockAgentRepository> MockGetAll(IEnumerable<Agent> result)
        {
            Setup(x => x.GetAll())
                .ReturnsAsync(result);

            return this;
        }
        public MockAgentRepository VerifyGetAll(Times times)
        {
            Verify(x => x.GetAll(), times);

            return this;
        }
        public async Task<MockAgentRepository> MockGetById(Agent result)
        {
            Setup(x => x.GetById(It.IsAny<int>()))
                .ReturnsAsync(result);

            return this;
        }

        public MockAgentRepository VerifyGetById(Times times)
        {
           
            Verify(x => x.GetById(It.IsAny<int>()), times);

            return this;
        }
    }
}