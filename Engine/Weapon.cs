using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Weapon : Item
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }

        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage) : base(id, name, namePlural)
        {
            MinDamage = minimumDamage;
            MaxDamage = maximumDamage;
        }
    }
}
