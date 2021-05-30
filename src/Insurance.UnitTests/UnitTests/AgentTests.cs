using System.Collections.Generic;
using System.Threading.Tasks;
using Insurance.BLL.Services;
using Insurance.DAL.Models;
using Insurance.Helpers.Params;
using Moq;
using Xunit;

namespace Insurance.UnitTests
{
    public class AgentTests
    {
        [Fact]
        public async Task AgentTests_GetAllAgents_ReturnsIEnumerableAgents()
        {
            // Arrange
            var mockAgents = new List<Agent> { new Agent(), };

            var mockAgentRepository = await new MockAgentRepository().MockGetAll(mockAgents);

            var mockUnitOfWork = new MockUnitOfWork().MockGetAgentRepository(mockAgentRepository.Object);

            var agentService = new AgentService(mockUnitOfWork.Object);

            // Act
            var agent = await agentService.GetAll();

            // Assert
            Assert.NotNull(agent);
            mockUnitOfWork.VerifyGetAgentRepository(Times.Once());
            mockAgentRepository.VerifyGetAll(Times.Once());
        }
        [Fact]
        public async Task AgentService_CalcSallary_AfterPostContract()
        {
           
        }

        [Fact]
        public async Task AgentTests_GetAgentById_ReturnAgent()
        {
            var mockAgent = new Agent();
            var mockAgentRepository = await new MockAgentRepository().MockGetById(mockAgent);
            var mockUnitOfWork = new MockUnitOfWork().MockGetAgentRepository(mockAgentRepository.Object);
            var agentService = new AgentService(mockUnitOfWork.Object);
            var agent = await agentService.GetById(2);
            Assert.NotNull(agent);
            mockUnitOfWork.VerifyGetAgentRepository(Times.Once());
            mockAgentRepository.VerifyGetById(Times.Once());
        }

        [Fact]
        public async Task AgentTests_GetAgent_NotNull()
        {
            var mockAgent = new Agent();
            var mockAgentRepository = await new MockAgentRepository().MockGetById(null);
            var mockUnitOfWork = new MockUnitOfWork().MockGetAgentRepository(mockAgentRepository.Object);
            var agentService = new AgentService(mockUnitOfWork.Object);
            var agent = await agentService.GetById(2);
            Assert.Null(agent);
            mockUnitOfWork.VerifyGetAgentRepository(Times.Once());
            mockAgentRepository.VerifyGetById(Times.Once());
        }
    }
}