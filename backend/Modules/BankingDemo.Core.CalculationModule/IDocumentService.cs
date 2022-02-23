using BankingDemo.Core.CalculationModule.Models;

namespace BankingDemo.Core.CalculationModule {
    public interface IDocumentService {
        Task<GetDocumentsResponse> Get(GetDocumentsRequest request);
    }
}
