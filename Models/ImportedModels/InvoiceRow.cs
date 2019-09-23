using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class InvoiceRow
    {
        public InvoiceRow()
        {
            InvoiceInvoiceRow = new HashSet<Invoice>();
            InvoiceInvoiceRowId1Navigation = new HashSet<Invoice>();
            InvoiceInvoiceRowId2Navigation = new HashSet<Invoice>();
            InvoiceInvoiceRowId3Navigation = new HashSet<Invoice>();
            InvoiceInvoiceRowId4Navigation = new HashSet<Invoice>();
            InvoiceInvoiceRowId5Navigation = new HashSet<Invoice>();
            InvoiceInvoiceRowId6Navigation = new HashSet<Invoice>();
            InvoiceInvoiceRowId7Navigation = new HashSet<Invoice>();
            InvoiceInvoiceRowId8Navigation = new HashSet<Invoice>();
            InvoiceInvoiceRowId9Navigation = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public int? ArticleId { get; set; }
        public double Quantity { get; set; }
        public double RowTotal { get; set; }
        public double ArticlePrice { get; set; }

        public virtual Article Article { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceRow { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceRowId1Navigation { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceRowId2Navigation { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceRowId3Navigation { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceRowId4Navigation { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceRowId5Navigation { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceRowId6Navigation { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceRowId7Navigation { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceRowId8Navigation { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceRowId9Navigation { get; set; }
    }
}
