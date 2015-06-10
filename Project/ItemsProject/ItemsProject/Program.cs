using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<item> stuff;
            inventory a = new inventory();
            a.add(new Helmet());
            a.add(new javelin());
            a.add(new javelin());
            a.add(new Helmet());
            a.add(new javelin());
            stuff = a.getList();
            foreach(item p in stuff)
            {
                Console.WriteLine(p.getname());
            }
            int i = 0;
            while(i == 0)
            {

            }
        }
    }
}
