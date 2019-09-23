using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public string InvoceHeader { get; set; }
        public int? CompanyId { get; set; }
        public int? CompanyId1 { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime Maturity { get; set; }
        public string PaymentTerms { get; set; }
        public int? InvoiceRowId { get; set; }
        public int? InvoiceRowId1 { get; set; }
        public int? InvoiceRowId2 { get; set; }
        public int? InvoiceRowId3 { get; set; }
        public int? InvoiceRowId4 { get; set; }
        public int? InvoiceRowId5 { get; set; }
        public int? InvoiceRowId6 { get; set; }
        public int? InvoiceRowId7 { get; set; }
        public int? InvoiceRowId8 { get; set; }
        public int? InvoiceRowId9 { get; set; }
        public string InvoceFooter { get; set; }

        public virtual Company Company { get; set; }
        public virtual Company CompanyId1Navigation { get; set; }
        public virtual InvoiceRow InvoiceRow { get; set; }
        public virtual InvoiceRow InvoiceRowId1Navigation { get; set; }
        public virtual InvoiceRow InvoiceRowId2Navigation { get; set; }
        public virtual InvoiceRow InvoiceRowId3Navigation { get; set; }
        public virtual InvoiceRow InvoiceRowId4Navigation { get; set; }
        public virtual InvoiceRow InvoiceRowId5Navigation { get; set; }
        public virtual InvoiceRow InvoiceRowId6Navigation { get; set; }
        public virtual InvoiceRow InvoiceRowId7Navigation { get; set; }
        public virtual InvoiceRow InvoiceRowId8Navigation { get; set; }
        public virtual InvoiceRow InvoiceRowId9Navigation { get; set; }
    }
}
