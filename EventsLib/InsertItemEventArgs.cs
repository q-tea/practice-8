using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGUI.EventsLib
{
    public class InsertItemEventArgs : EventArgs
    {
        public AbonentInfo abonent;

        public InsertItemEventArgs(AbonentInfo abonent)
        {
            this.abonent = abonent;
        }
    }
}
