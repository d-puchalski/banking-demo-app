using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingDemo.Core.Extensions.EF.Models {

    public class CalculationDocument {
        public int Type { get; set; }
        public int Status { get; set; }
    }
}
