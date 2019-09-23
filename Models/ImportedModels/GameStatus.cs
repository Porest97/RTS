using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class GameStatus
    {
        public GameStatus()
        {
            Game = new HashSet<Game>();
        }

        public int Id { get; set; }
        public string GameStatusName { get; set; }

        public virtual ICollection<Game> Game { get; set; }
    }
}
