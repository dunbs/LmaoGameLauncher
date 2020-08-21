using LmaoGame.UI;
using LmaoGame.UI.LmaoEvent;
using ProjectPRN_DAOTesting.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame
{
    static class UserControl
    {
        private static Account user;
        public static EventHandler<LoginStateChanged_EventArgs> LoginStateChanged;

        internal static Account User
        {
            get { return user; }
            set
            {
                user = value;
                LoginStateChanged?.Invoke(null, new LoginStateChanged_EventArgs(user != null));
            }
        }

        internal static bool IsLoggedIn => user != null;

        internal static void RequestLogin()
        {
            new Login().Show();
        }

        internal static void RequestLogout()
        {
            User = null;
        }

    }
}
