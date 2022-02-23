
using BankingDemo.Core.CalculationModule.Enums;

namespace BankingDemo.Core.CalculationModule.Models {
    public class Document {
        public DocumentTypeEnum Type { get; set; }
        public byte[] File { get; set; }
        public string FileName { get; set; }
        public DocumentStatusEnum Status { get; set; }
    }
}
