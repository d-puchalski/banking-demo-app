using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingDemo.Core.Extensions.EF.Models {

    public class CalculationDocuments {

        public List<CalculationDocument> Documents { get; set; }

    }
}
