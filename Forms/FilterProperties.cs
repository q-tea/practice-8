using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLGUI.EventsLib;

namespace XMLGUI.Forms
{
    public partial class FilterProperties : Form
    {
        public event EventHandler<FilterChangeEventArgs> FilterChangeEvent;
        public FilterProperties()
        {
            InitializeComponent();
        }

        private void OnBtnApplyClick(object sender, EventArgs e)
        {
            EventHandler<FilterChangeEventArgs> handler = FilterChangeEvent;
            handler?.Invoke(this, new FilterChangeEventArgs(this.paramTxtBoxName.Text,
                this.paramTxtBoxLocation.Text,
                this.paramTxtBoxStartDate.Text,
                this.paramTxtBoxName.Text));
            this.Close();
        }

        private void FilterProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
