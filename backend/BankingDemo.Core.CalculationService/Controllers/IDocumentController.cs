using BankingDemo.Core.CalculationModule.Models;
using System.Threading.Tasks;

namespace BankingDemo.Core.CalculationService.Controllers {
    public interface IDocumentController {
        Task<GetDocumentsResponse> Get(GetDocumentsRequest request);
    }
}
