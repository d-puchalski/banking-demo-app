using BankingDemo.Core.ProfileModule.Models;

namespace BankingDemo.Core.ProfileModule {
    public interface IProfileService {
        Task<GetProfileResponse> Get();

        Task<GetProfileResponse> Update(UpdateProfileRequest request);
    }
}
