using BankingDemo.Core.CalculationModule;
using BankingDemo.Core.CalculationModule.Models;
using BankingDemo.Core.Extensions.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace BankingDemo.Core.CalculationService.Controllers {
    [ApiController]
    [Authorize]
    [Route("api/document")]
    public class DocumentController : CustomControllerBase<DocumentController>, IDocumentController {
        private readonly IDocumentService _service;

        public DocumentController(ILogger<DocumentController> logger, IDocumentService service) : base(logger) {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        [SwaggerOperation(OperationId = "get")]
        public async Task<GetDocumentsResponse> Get(GetDocumentsRequest request) {
            return await _service.Get(request);
        }
    }
}
