using BankingDemo.Core.Extensions.EF.Connections;
using BankingDemo.Core.Extensions.EF.Models;
using BankingDemo.Core.Extensions.Shared;
using BankingDemo.Core.SharedModule.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BankingDemo.Core.SharedModule {
    public class SystemService : CustomServiceBase<ISystemService>, ISystemService {
        public SystemService(ILogger<ISystemService> logger) : base(logger) {
        }

        public async Task<SystemGetResponse> GetSystemInfo() {
            SystemGetResponse response = new SystemGetResponse {
                BankDate = DateTime.Today
            };
            return response;
        }
    }
}
