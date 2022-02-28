using BankingDemo.Core.CalculationModule.Models;
using BankingDemo.Core.Extensions.Scoring.Interface.Models;

namespace BankingDemo.Core.CalculationModule {
    public interface ICalculatorService {
        Task<GetCalculationResponse> Create(GetCalculationRequest request);
        Task<bool> Activation(Guid request);
        Task<(bool, GetCalculationResponse)> CheckClientValues(GetCalculationRequest request);
        Task<ScoringResult> Score(GetCalculationRequest request);
    }
}