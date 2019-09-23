using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Camp
    {
        public Camp()
        {
            Activity = new HashSet<Activity>();
            Person = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string CampName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CampDescription { get; set; }
        public int? ArenaId { get; set; }

        public virtual Arena Arena { get; set; }
        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}
