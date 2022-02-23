using BankingDemo.Core.CalculationModule.Models;

namespace BankingDemo.Core.CalculationModule {
    public interface ICalculatorService {
        Task<GetCalculationResponse> Create(GetCalculationRequest request);
        Task<bool> Activation(Guid request);
    }
}
