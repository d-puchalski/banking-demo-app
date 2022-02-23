using BankingDemo.Core.Extensions.Shared;
using BankingDemo.Core.ProfileModule;
using BankingDemo.Core.ProfileModule.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace BankingDemo.Core.ProfileService.Controllers {
    [ApiController]
    [Authorize]
    [Route("api/profile")]
    public class ProfileController : CustomControllerBase<ProfileController>, IProfileController {
        private readonly IProfileService _service;

        public ProfileController(ILogger<ProfileController> logger, IProfileService service) : base(logger) {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        [SwaggerOperation(OperationId = "get")]
        public async Task<GetProfileResponse> Get() {
            return await _service.Get();
        }

        [HttpPut]
        [Route("")]
        [SwaggerOperation(OperationId = "put")]
        public async Task<GetProfileResponse> Put(UpdateProfileRequest request) {
            return await _service.Update(request);
        }
    }
}
