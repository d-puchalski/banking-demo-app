using BankingDemo.Core.AccountModule.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemo.Core.AccountModule.Models {
    public class Account {
        public Guid UID { get; set; }

        public string IBAN { get; set; }

        public decimal Balance { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public AccountTypeEnum Type { get; set; }

        public AccountStatusEnum Status { get; set; }
    }
}
