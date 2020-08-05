using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHP = currentHitPoints;
            MaxHP = maximumHitPoints;
        }
    }
}
