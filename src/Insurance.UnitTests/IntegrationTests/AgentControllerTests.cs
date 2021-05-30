using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Insurance.DTO.DTO;
using Insurance.UnitTests.IntegrationTests.app;
using Xunit;

namespace Insurance.UnitTests.IntegrationTests
{
    public class AgentControllerTests : IClassFixture<CommonApplicationFactory<Insurance.WEBAPI.Startup>>
    {
        private readonly HttpClient _client;
        private readonly CommonApplicationFactory<Insurance.WEBAPI.Startup> _factory;

        public AgentControllerTests(CommonApplicationFactory<Insurance.WEBAPI.Startup> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }

        [Fact]
        public async Task ClientController_GetAll_ReturnsOK()
        {
            // Arrange
            var url = "api/v1/agent";

            // Act
            var response = await _client.GetAsync(url);

            var result = JsonSerializer.Deserialize<IEnumerable<AgentDTO>>(await response.Content.ReadAsStringAsync());
            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task ClientController_GetByExistentId_ReturnsOk()
        {
            // Arrange
            var url = "api/v1/Agent/1";
            // Act
            var response = await _client.GetAsync(url);
            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

       
        [Fact]
        public async Task ClientController_GetByNonExistentId_ReturnsNoContent()
        {
            // Arrange
            var url = "api/v1/Agent/0";
            // Act
            var response = await _client.GetAsync(url);
            // Assert
            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }

        [Fact]
        public async Task ClientController_PostValidAgent_ReturnsOk()
        {
            // Arrange
            var url = "api/v1/Agent/";
            var content = new StringContent(JsonSerializer.Serialize(
                new AgentDTO
                {
                    FirstName = "Olexandro",
                    SecondName = "Git master",
                    BranchId = 1
                }),
                Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync(url, content);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ClientController_PostInvalidAgent_ReturnsBadRequest()
        {
            // Arrange
            var url = "api/v1/Agent/";
            var content = new StringContent(JsonSerializer.Serialize(new AgentDTO ()), Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync(url, content);

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}