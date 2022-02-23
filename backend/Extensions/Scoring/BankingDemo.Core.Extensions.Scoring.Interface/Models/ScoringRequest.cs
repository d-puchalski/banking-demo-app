
namespace BankingDemo.Core.Extensions.Scoring.Interface.Models {
    public class ScoringRequest {
        public string SSN { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal PeriodicAmount { get; set; }
    }
}
