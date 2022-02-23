using BankingDemo.Core.Extensions.Shared;
using BankingDemo.Core.SharedModule;
using BankingDemo.Core.SharedModule.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace BankingDemo.Core.SharedService.Controllers {
    [ApiController]
    //[Authorize]
    [Route("api/shared/system")]
    public class SystemController : CustomControllerBase<SystemController>, ISystemController {
        private readonly ISystemService _systemService;

        public SystemController(ILogger<SystemController> logger, ISystemService systemService) : base(logger) {
            _systemService = systemService;
        }

        [HttpGet]
        [Route("")]
        [SwaggerOperation(OperationId = "get")]
        public async Task<SystemGetResponse> Get() {
            return await _systemService.GetSystemInfo();
        }
    }
}
