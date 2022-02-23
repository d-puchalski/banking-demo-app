using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingDemo.Core.Extensions.EF.Models {
    public class CalculationOwnerConsents {

        public bool Marketing { get; set; }

        public bool RODO { get; set; }

    }
}
