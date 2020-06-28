using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGUI.EventsLib
{
    public class DeleteItemEventArgs : EventArgs
    {
        public string ID { get; internal set; }

        public DeleteItemEventArgs(string ID)
        {
            this.ID = ID;
        }
    }
}
