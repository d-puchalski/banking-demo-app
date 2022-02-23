
using BankingDemo.Core.CalculationModule.Enums;

namespace BankingDemo.Core.CalculationModule.Models {
    public class GetDocumentsResponse {
        public Guid UID { get; set; }
        public List<Document> Documents { get; set; }
    }
}
