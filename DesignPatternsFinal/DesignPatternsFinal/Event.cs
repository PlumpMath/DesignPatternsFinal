using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsFinal
{
    public abstract class Event
    {
        public Event()
        {

        }
        public abstract void onTrigger();
    }
}
