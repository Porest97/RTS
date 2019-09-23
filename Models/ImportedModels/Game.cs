using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Game
    {
        public Game()
        {
            GameReceipt = new HashSet<GameReceipt>();
        }

        public int Id { get; set; }
        public int? GameCategoryId { get; set; }
        public string GameNumber { get; set; }
        public DateTime GameDateTime { get; set; }
        public int? ArenaId { get; set; }
        public int? TeamId { get; set; }
        public int? TeamId1 { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? AwayTeamScore { get; set; }
        public int? PersonId { get; set; }
        public int? PersonId1 { get; set; }
        public int? PersonId2 { get; set; }
        public int? PersonId3 { get; set; }
        public string Tsmnumber { get; set; }
        public int? GameStatusId { get; set; }

        public virtual Arena Arena { get; set; }
        public virtual GameCategory GameCategory { get; set; }
        public virtual GameStatus GameStatus { get; set; }
        public virtual Person Person { get; set; }
        public virtual Person PersonId1Navigation { get; set; }
        public virtual Person PersonId2Navigation { get; set; }
        public virtual Person PersonId3Navigation { get; set; }
        public virtual Team Team { get; set; }
        public virtual Team TeamId1Navigation { get; set; }
        public virtual ICollection<GameReceipt> GameReceipt { get; set; }
    }
}
