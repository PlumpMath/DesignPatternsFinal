using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemsProject
{
    class inventory
    {
        private System.Collections.Generic.List<item> stuff;
        public inventory()
        {
            stuff = new List<item>();
        }

        public List<item> getList()
        {
            return stuff;
        }

        public void add(item items)
        {
            stuff.Add(items);
        }
    }
}
