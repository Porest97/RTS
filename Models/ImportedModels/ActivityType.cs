using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class ActivityType
    {
        public ActivityType()
        {
            Activity = new HashSet<Activity>();
        }

        public int Id { get; set; }
        public string ActivityTypeName { get; set; }

        public virtual ICollection<Activity> Activity { get; set; }
    }
}
