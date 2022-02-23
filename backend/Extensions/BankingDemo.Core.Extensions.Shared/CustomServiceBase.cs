using Microsoft.Extensions.Logging;

namespace BankingDemo.Core.Extensions.Shared {
    public class CustomServiceBase<T> {

        public readonly ILogger<T> _logger;

        public CustomServiceBase(ILogger<T> logger) {
            _logger = logger;
        }
    }
}
