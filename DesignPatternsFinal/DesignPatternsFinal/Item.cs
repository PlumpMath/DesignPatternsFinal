using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public abstract class Item
    {
        public String name { get { return name; } set { name = value; } }
        public int damageMax { get { return damageMax; } set { damageMax = value; } }
        public int damageMin { get { return damageMin; } set { damageMin = value; } }
        public int healMax { get { return healMax; } set { healMax = value; } }
        public int healMin { get { return healMin; } set { healMin = value; } }
        public int poisonMax { get { return poisonMax; } set { poisonMax = value; } }
        public int poisonMin { get { return poisonMin; } set { poisonMin = value; } }
        public int blockMax { get { return blockMax; } set { blockMax = value; } }
        public int blockMin { get { return blockMin; } set { blockMin = value; } }
        public Item()
        {}
    }
}
