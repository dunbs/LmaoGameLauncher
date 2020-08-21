using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmaoGame.UI.LmaoEvent
{
    class LoginStateChanged_EventArgs : EventArgs
    {
        bool isLoggedIn;

        public LoginStateChanged_EventArgs(bool isLoggedIn)
        {
            this.isLoggedIn = isLoggedIn;
        }

        public bool IsLoggedIn { get => isLoggedIn; }
    }
}
