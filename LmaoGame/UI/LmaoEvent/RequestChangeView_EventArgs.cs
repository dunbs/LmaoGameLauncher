using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoGame.UI.LmaoEvent
{
    public class RequestChangeView_EventArgs : EventArgs
    {
        public Form RequestedForm { get; set; }

        public RequestChangeView_EventArgs(Form requestedForm) => RequestedForm = requestedForm;


    }
}
