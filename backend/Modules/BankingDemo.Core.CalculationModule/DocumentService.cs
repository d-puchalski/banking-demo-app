using BankingDemo.Core.CalculationModule.Models;
using BankingDemo.Core.Extensions.Shared;
using Microsoft.Extensions.Logging;

namespace BankingDemo.Core.CalculationModule {
    public class DocumentService : CustomServiceBase<IDocumentService>, IDocumentService {
        public DocumentService(ILogger<IDocumentService> logger) : base(logger) {

        }

        public async Task<GetDocumentsResponse> Get(GetDocumentsRequest request) {
            throw new NotImplementedException();
        }
    }
}
