using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Company
    {
        public Company()
        {
            InvoiceCompany = new HashSet<Invoice>();
            InvoiceCompanyId1Navigation = new HashSet<Invoice>();
            Person = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<Invoice> InvoiceCompany { get; set; }
        public virtual ICollection<Invoice> InvoiceCompanyId1Navigation { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}
