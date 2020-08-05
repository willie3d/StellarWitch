using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class SpellType : Spells
    {
        public string Type { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public SpellType(string type, int minimumDamage, int maximumDamage) : base(type)
        {
            Type = type;
            MaxDamage = maximumDamage;
            MinDamage = minimumDamage;
        }
    }
}