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
        private System.Windows.Forms.Form NavigationForm;

        private NavigationState()
        {
            NavigationForm = new NavigationViewForm();
            base.navigationState = _navigationState;
        }
        override protected void toNavigate()
        {
            
        }
        override public System.Windows.Forms.Form StateView()
        {
            return NavigationForm;
        }

        public static State initNavigationState()
        {
            if (_navigationState == null)
                _navigationState = new NavigationState();
            return _navigationState;
        }
    }
}
