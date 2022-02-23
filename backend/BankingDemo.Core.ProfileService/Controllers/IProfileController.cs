using BankingDemo.Core.ProfileModule.Models;
using System.Threading.Tasks;

namespace BankingDemo.Core.ProfileService.Controllers {
    public interface IProfileController {
        Task<GetProfileResponse> Get();

        Task<GetProfileResponse> Put(UpdateProfileRequest request);
    }
}
