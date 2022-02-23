using BankingDemo.Core.SharedModule.Models;

namespace BankingDemo.Core.SharedModule {
    public interface ISystemService {
        public Task<SystemGetResponse> GetSystemInfo();
    }
}
