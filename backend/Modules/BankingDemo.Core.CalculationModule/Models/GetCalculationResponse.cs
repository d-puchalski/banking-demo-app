
using BankingDemo.Core.CalculationModule.Enums;

namespace BankingDemo.Core.CalculationModule.Models {
    public class GetCalculationResponse {
        public Guid UID { get; set; }
        public decimal Instalment { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
        public ScoringResultEnum ScoringResult { get; set; }
    }
}
