using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class ReceiptStatus
    {
        public ReceiptStatus()
        {
            GameReceipt = new HashSet<GameReceipt>();
        }

        public int Id { get; set; }
        public string ReceiptStatusName { get; set; }

        public virtual ICollection<GameReceipt> GameReceipt { get; set; }
    }
}
