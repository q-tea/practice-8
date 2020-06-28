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
    public partial class InsertItems : Form
    {
        public event EventHandler<InsertItemEventArgs> InsertItemEvent;
        public InsertItems()
        {
            InitializeComponent();
        }
        private void OnBtnApplyClick(object sender, EventArgs e)
        {
            EventHandler<InsertItemEventArgs> handler = InsertItemEvent;
            AbonentInfo abonentInfo = new AbonentInfo
            {
                Name = paramTxtBoxName.Text,
                Location = paramTxtBoxLocation.Text,
                Address = paramTxtBoxAddress.Text,
                Phone = paramTxtBoxPhone.Text,
                ID = paramTxtBoxID.Text,
                StartDate = paramTxtBoxStartDate.Text,
                InstallationPayment = paramTxtBoxInstallationPayment.Text,
                Fee = paramTxtBoxFee.Text,
                LastPayment = paramTxtBoxLastPayment.Text,
            };
            handler?.Invoke(this, new InsertItemEventArgs(abonentInfo));
            this.Close();
        }
        private void InsertItems_Load(object sender, EventArgs e)
        {

        }
    }
}