using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Article
    {
        public Article()
        {
            InvoiceRow = new HashSet<InvoiceRow>();
        }

        public int Id { get; set; }
        public string ArticleDescription { get; set; }
        public double ArticlePrice { get; set; }

        public virtual ICollection<InvoiceRow> InvoiceRow { get; set; }
    }
}
