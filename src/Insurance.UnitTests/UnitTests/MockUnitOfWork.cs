using Insurance.Repositories.Interfaces.IRepositories;
using Insurance.Repositories.UnitOfWork.Interfaces;
using Moq;

namespace Insurance.UnitTests
{
    class MockUnitOfWork : Mock<IUnitOfWork>
    {
        public MockUnitOfWork MockGetAgentRepository(IAgentRepository result)
        {
            Setup(x => x.AgentRepository)
                .Returns(result);

            return this;
        }

        public MockUnitOfWork VerifyGetAgentRepository(Times times)
        {
            Verify(x => x.AgentRepository, times);

            return this;
        }
    }
}