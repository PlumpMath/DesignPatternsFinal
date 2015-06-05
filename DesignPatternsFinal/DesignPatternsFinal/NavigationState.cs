using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public class NavigationState : State
    {
        private static NavigationState _navigationState;
        private static System.Windows.Forms.Form NavigationForm;

        private NavigationState(World d) : base(d)
        {
            NavigationForm = new NavigationViewForm(ref d);
            _navigationState = this;
            navigationState = _navigationState;
        }
        new public void toNavigate()
        {
            
        }
        override public System.Windows.Forms.Form StateView()
        {
            return NavigationForm;
        }

        public static State initNavigationState(World d)
        {
            if (_navigationState == null)
                _navigationState = new NavigationState(d);
            return _navigationState;
        }
    }
}
