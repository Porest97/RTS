using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class District
    {
        public District()
        {
            Club = new HashSet<Club>();
        }

        public int Id { get; set; }
        public string DistrictName { get; set; }

        public virtual ICollection<Club> Club { get; set; }
    }
}
