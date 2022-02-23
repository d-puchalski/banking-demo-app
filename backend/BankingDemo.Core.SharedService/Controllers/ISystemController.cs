using BankingDemo.Core.SharedModule.Models;
using System.Threading.Tasks;

namespace BankingDemo.Core.SharedService.Controllers {
    public interface ISystemController {
        Task<SystemGetResponse> Get();
    }
}
