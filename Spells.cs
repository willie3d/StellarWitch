using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Spells 
    {
        

        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Spells(string name, int id )
        {
            Name = name;
            ID = id;
            

        }

        public Spells(string type)
        {
            this.type = type;
        }
    }
}
