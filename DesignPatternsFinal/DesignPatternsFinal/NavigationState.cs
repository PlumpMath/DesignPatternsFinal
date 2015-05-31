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
        private static World theWorld;
        private NavigationState(ref World d)
        {
            theWorld = d;
            NavigationForm = new NavigationViewForm(ref d);
            base.navigationState = _navigationState;
        }
        override protected void toNavigate()
        {
            
        }
        override public System.Windows.Forms.Form StateView()
        {
            return NavigationForm;
        }

        public static State initNavigationState(ref World d)
        {
            if (_navigationState == null)
                _navigationState = new NavigationState(ref d);
            return _navigationState;
        }
    }
}
