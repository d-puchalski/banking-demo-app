using BankingDemo.Core.AccountModule.Models;
using BankingDemo.Core.Extensions.Shared;
using Microsoft.Extensions.Logging;

namespace BankingDemo.Core.AccountModule {
    public class AccountService : CustomServiceBase<IAccountService>, IAccountService {
        public AccountService(ILogger<IAccountService> logger) : base(logger) {

        }

        public async Task<GetAccountResponse> Get() {
            throw new NotImplementedException();
        }

        public async Task<GetAccountListResponse> GetList() {
            GetAccountListResponse response = new GetAccountListResponse();
            response.Accounts = new List<Account>();
            response.Accounts.Add(new Account() {
                Balance = 800
            });
            return response;
        }
    }
}
