using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingDemo.Core.Extensions.EF.Models {

    public class Calculation {
        [Key]
        public Guid Seq { get; set; }

        [Required]
        [Range(1, 10000000)]
        public decimal Amount { get; set; }

        [Required]
        [Range(1, 999)]
        public int Periods { get; set; }

        [Required]
        public decimal Instalment { get; set; }

        [Required]
        [Range(0, 999)]
        public decimal Rate { get; set; }

        [Required]
        public decimal TotalCost { get; set; }

        [Required]
        public CalculationOwner Owner { get; set; }

    }
}
