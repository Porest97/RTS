using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Tournament
    {
        public Tournament()
        {
            Match = new HashSet<Match>();
            Team = new HashSet<Team>();
        }

        public int Id { get; set; }
        public string TournamentName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TournamentDescription { get; set; }
        public int? ArenaId { get; set; }

        public virtual Arena Arena { get; set; }
        public virtual ICollection<Match> Match { get; set; }
        public virtual ICollection<Team> Team { get; set; }
    }
}
