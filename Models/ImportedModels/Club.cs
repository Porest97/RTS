using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Club
    {
        public Club()
        {
            Person = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string ClubName { get; set; }
        public int? DistrictId { get; set; }

        public virtual District District { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}
