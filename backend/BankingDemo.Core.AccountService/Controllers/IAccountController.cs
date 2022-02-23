using BankingDemo.Core.AccountModule.Models;
using System.Threading.Tasks;

namespace BankingDemo.Core.AccountService.Controllers {
    public interface IAccountController {
        Task<GetAccountResponse> Get();
        Task<GetAccountListResponse> GetList();
    }
}
