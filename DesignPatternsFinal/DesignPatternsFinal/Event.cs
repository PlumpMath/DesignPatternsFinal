using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsFinal
{
    public interface Event
    {
        void onTrigger(int roomNum);
    }
}
