using BankingDemo.Core.CalculationModule;
using BankingDemo.Core.CalculationModule.Models;
using BankingDemo.Core.Extensions.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net;
using System.Threading.Tasks;

namespace BankingDemo.Core.CalculationService.Controllers {
    [ApiController]
    [Route("api/calculation")]
    public class CalculatorController : CustomControllerBase<CalculatorController>, ICalculatorController {
        private readonly ICalculatorService _service;
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger, ICalculatorService service) : base(logger) {
            _service = service;
            _logger = logger;
        }

        [HttpPost]
        [Route("")]
        [SwaggerOperation(OperationId = "post")]
        public async Task<ActionResult<GetCalculationResponse>> Post([FromBody] GetCalculationRequest request) {
            try {
                return CreatedAtAction(nameof(Post), await _service.Create(request));
            } catch (Exception e) {
                return base.error500<GetCalculationResponse>(e);
            }
        }

        [HttpPut]
        [Route("")]
        [SwaggerOperation(OperationId = "put")]
        public async Task<ActionResult<bool>> Put([FromQuery] Guid request) {
            try {
                return CreatedAtAction(nameof(Put), await _service.Activation(request));
            } catch (Exception e) {
                return base.error500<bool>(e);
            }
        }
    }
}
