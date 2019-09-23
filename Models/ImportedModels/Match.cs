using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Match
    {
        public Match()
        {
            Receipt = new HashSet<Receipt>();
        }

        public int Id { get; set; }
        public int? MatchCategoryId { get; set; }
        public string MatchNumber { get; set; }
        public DateTime MatchDateTime { get; set; }
        public int? ArenaId { get; set; }
        public int? TeamId { get; set; }
        public int? TeamId1 { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? AwayTeamScore { get; set; }
        public int? PersonId { get; set; }
        public int? PersonId1 { get; set; }
        public int? PersonId2 { get; set; }
        public int? PersonId3 { get; set; }
        public int? TournamentId { get; set; }

        public virtual Arena Arena { get; set; }
        public virtual MatchCategory MatchCategory { get; set; }
        public virtual Person Person { get; set; }
        public virtual Person PersonId1Navigation { get; set; }
        public virtual Person PersonId2Navigation { get; set; }
        public virtual Person PersonId3Navigation { get; set; }
        public virtual Team Team { get; set; }
        public virtual Team TeamId1Navigation { get; set; }
        public virtual Tournament Tournament { get; set; }
        public virtual ICollection<Receipt> Receipt { get; set; }
    }
}
