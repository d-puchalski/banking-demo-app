using BankingDemo.Core.AccountModule.Models;

namespace BankingDemo.Core.AccountModule {
    public interface IAccountService {
        Task<GetAccountResponse> Get();
        Task<GetAccountListResponse> GetList();
    }
}
