using System.Threading.Tasks;
using Clients.Application.Documents;
using Clients.Application.Documents.Commands;
using Clients.Application.Documents.Queries;
using Clients.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clients.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IDocumentService _service;

        public DocumentsController(IMediator mediator, IDocumentService service)
        {
            _mediator = mediator;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllDocumetsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetByIdDocumentQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Document document)
        {
            var command = new CreateDocumentsCommand(document);
            await _mediator.Send(command);
           // await _service.CreateDocument(document);
            return Ok();
        }
    }
}