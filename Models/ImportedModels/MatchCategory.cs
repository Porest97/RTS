using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class MatchCategory
    {
        public MatchCategory()
        {
            Match = new HashSet<Match>();
        }

        public int Id { get; set; }
        public string MatchCategoryName { get; set; }

        public virtual ICollection<Match> Match { get; set; }
    }
}
