using BankingDemo.Core.AccountModule;
using BankingDemo.Core.AccountModule.Models;
using BankingDemo.Core.Extensions.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BankingDemo.Core.AccountService.Controllers {
    [ApiController]
    [Authorize]
    [Route("api/account")]
    public class AccountController : CustomControllerBase<AccountController>, IAccountController {
        private readonly IAccountService _service;

        public AccountController(ILogger<AccountController> logger, IAccountService service) : base(logger) {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        [SwaggerOperation(OperationId = "get")]
        public async Task<GetAccountResponse> Get() {
            return await _service.Get();
        }

        [HttpGet]
        [Route("list")]
        [SwaggerOperation(OperationId = "get-list")]
        public async Task<GetAccountListResponse> GetList() {
            return await _service.GetList();
        }
    }
}
