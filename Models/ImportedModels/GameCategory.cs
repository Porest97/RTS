using System;
using System.Collections.Generic;

namespace RTS.Models.ImportedModels
{
    public partial class GameCategory
    {
        public GameCategory()
        {
            Game = new HashSet<Game>();
        }

        public int Id { get; set; }
        public string GameCategoryName { get; set; }

        public virtual ICollection<Game> Game { get; set; }
    }
}
