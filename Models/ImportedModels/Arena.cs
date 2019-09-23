using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class Arena
    {
        public Arena()
        {
            Activity = new HashSet<Activity>();
            Camp = new HashSet<Camp>();
            Game = new HashSet<Game>();
            Match = new HashSet<Match>();
            Tournament = new HashSet<Tournament>();
        }

        public int Id { get; set; }
        public string ArenaName { get; set; }

        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<Camp> Camp { get; set; }
        public virtual ICollection<Game> Game { get; set; }
        public virtual ICollection<Match> Match { get; set; }
        public virtual ICollection<Tournament> Tournament { get; set; }
    }
}
