using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingDemo.Core.Extensions.EF.Models {
    public class CalculationOwnerAddress {
        [Required]
        [StringLength(500)]
        public string Address1 { get; set; }

        [StringLength(500)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Zip { get; set; }

        [Required]
        [StringLength(2)]
        public string Country { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$")]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
