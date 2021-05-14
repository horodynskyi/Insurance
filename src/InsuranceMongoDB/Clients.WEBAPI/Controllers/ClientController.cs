using System.Threading.Tasks;
using Clients.Application.Interfaces;
using Clients.Application.Queries;
using Clients.Application.Queries.Clients;
using Clients.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clients.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IMediator _mediator;
        public ClientController(IClientService clientService, IMediator mediator)
        {
            _clientService = clientService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetlAllClientsQuery();
            var result = _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetClientQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Client client)
        {
            await _clientService.CreateClient(client);
            return Ok();
        }
    }
}