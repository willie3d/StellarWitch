using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuest
    {
        public Quests Details { get; set; }
        public bool IsCompleted { get; set; }

        public PlayerQuest(Quests details)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
