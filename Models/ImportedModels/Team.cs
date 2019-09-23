using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Team
    {
        public Team()
        {
            GameTeam = new HashSet<Game>();
            GameTeamId1Navigation = new HashSet<Game>();
            MatchTeam = new HashSet<Match>();
            MatchTeamId1Navigation = new HashSet<Match>();
            Person = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string TeamName { get; set; }
        public int? TournamentId { get; set; }

        public virtual Tournament Tournament { get; set; }
        public virtual ICollection<Game> GameTeam { get; set; }
        public virtual ICollection<Game> GameTeamId1Navigation { get; set; }
        public virtual ICollection<Match> MatchTeam { get; set; }
        public virtual ICollection<Match> MatchTeamId1Navigation { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}
