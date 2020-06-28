using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGUI.EventsLib
{
    public class FilterChangeEventArgs : EventArgs
    {
        public string Name { get; internal set; }
        public string Location { get; internal set; }
        public string StartDate { get; internal set; }
        public string LastPayment { get; internal set; }

        public FilterChangeEventArgs(string Name, string Location, string StartDate, string LastPayment)
        {
            this.Name = Name;
            this.Location = Location;
            this.StartDate = StartDate;
            this.LastPayment = LastPayment;
        }
    }
}
