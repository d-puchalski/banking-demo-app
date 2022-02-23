using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemo.Core.ProfileModule.Models {
    public class Profile {
        public Guid UID { get; set; }

        public string Address1 { get; set; }

        public string? Address2 { get; set; }

        public string Zip { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
