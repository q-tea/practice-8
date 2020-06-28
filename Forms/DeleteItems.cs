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
    public partial class DeleteItems : Form
    {
        public event EventHandler<DeleteItemEventArgs> DeleteItemEvent;
        public DeleteItems()
        {
            InitializeComponent();
        }
        private void OnBtnApplyClick(object sender, EventArgs e)
        {
            EventHandler<DeleteItemEventArgs> handler = DeleteItemEvent;
            handler?.Invoke(this, new DeleteItemEventArgs(this.paramTxtBoxID.Text));
            this.Close();
        }

        private void DeleteItems_Load(object sender, EventArgs e)
        {

        }
    }
}
