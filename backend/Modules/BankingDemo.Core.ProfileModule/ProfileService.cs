using BankingDemo.Core.Extensions.Shared;
using BankingDemo.Core.ProfileModule.Models;
using Microsoft.Extensions.Logging;

namespace BankingDemo.Core.ProfileModule {
    public class ProfileService : CustomServiceBase<IProfileService>, IProfileService {
        public ProfileService(ILogger<IProfileService> logger) : base(logger) {

        }

        public async Task<GetProfileResponse> Get() {
            throw new NotImplementedException();
        }

        public async Task<GetProfileResponse> Update(UpdateProfileRequest request) {
            throw new NotImplementedException();
        }
    }
}
