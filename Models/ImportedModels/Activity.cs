using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Activity
    {
        public Activity()
        {
            Person = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string ActivityName { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string ActivityDescription { get; set; }
        public int? ArenaId { get; set; }
        public int? ActivityTypeId { get; set; }
        public int? CampId { get; set; }

        public virtual ActivityType ActivityType { get; set; }
        public virtual Arena Arena { get; set; }
        public virtual Camp Camp { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}
