using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingDemo.Core.Extensions.EF.Models {

    public class CalculationOwner {
        [Required]
        [RegularExpression("^[0-9]*$")]
        public string SSN { get; set; }

        [Required]
        [StringLength(500)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(500)]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public CalculationOwnerAddress Address { get; set; }

        [Required]
        public CalculationOwnerConsents Consents { get; set; }
    }
}
