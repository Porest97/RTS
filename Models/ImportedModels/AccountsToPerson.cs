using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class AccountsToPerson
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public string SwishNumber { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }

        public virtual Person Person { get; set; }
    }
}
