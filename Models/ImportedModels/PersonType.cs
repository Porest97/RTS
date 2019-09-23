using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class PersonType
    {
        public PersonType()
        {
            Person = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string PersonTypeName { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
