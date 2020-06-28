using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


using XMLGUI.Forms;
using XMLGUI.EventsLib;
using System.Xml.Linq;

namespace XMLGUI
{
    public struct AbonentInfo
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ID { get; set; }
        public string StartDate { get; set; }
        public string InstallationPayment { get; set; }
        public string Fee { get; set; }
        public string LastPayment { get; set; }
    }
    public partial class XMLViewer : Form
    {
        XDocument xDoc = new XDocument(new XElement("ArrayOfAbonentInfo", ""));
        List<XElement> abonentInfoFiltered = new List<XElement>();
        public XMLViewer()
        {
            InitializeComponent();
        }

        private void OnSetFilterClick(object sender, EventArgs e)
        {
            FilterProperties setFilterForm = new FilterProperties();
            setFilterForm.FilterChangeEvent += new EventHandler<FilterChangeEventArgs>(OnFilterChangeEvent);
            setFilterForm.Show();
        }

        public void OnFilterChangeEvent(object sender, FilterChangeEventArgs e)
        {
            XElement abonents = XElement.Load(Path.Combine(Directory.GetCurrentDirectory(), "abonents.xml"));
            abonentInfoFiltered = (from abonent in abonents.Descendants("AbonentInfo")
                    where ((string)abonent.Element("Name") == e.Name ||
                    (string)abonent.Element("Location") == e.Location ||
                    (string)abonent.Element("StartDate") == e.StartDate ||
                    (string)abonent.Element("LastPayment") == e.LastPayment ||
                    e.Name == "" && e.Location == "" && e.StartDate == "" && e.LastPayment == "")
                    select abonent).ToList();
            tableView.Text += "Name".PadRight(10) +
                    "Location".PadRight(10) +
                    "Address".PadRight(20) +
                    "Phone".PadRight(10) +
                    "ID".PadRight(10) +
                    "StartDate".PadRight(15) +
                    "LastPayment".PadRight(15) + Environment.NewLine;
            Save();
            Print();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableView.Clear();
        }

        public void Save()
        {
            xDoc = new XDocument(new XElement("ArrayOfAbonentInfo", ""));
            foreach (var abonent in abonentInfoFiltered)
            {
                xDoc.Element("ArrayOfAbonentInfo").Add(new XElement("AbonentInfo",
                    new XElement(abonent.Element("Name")),
                    new XElement(abonent.Element("Location")),
                    new XElement(abonent.Element("Address")),
                    new XElement(abonent.Element("Phone")),
                    new XElement(abonent.Element("ID")),
                    new XElement(abonent.Element("StartDate")),
                    new XElement(abonent.Element("InstallationPayment")),
                    new XElement(abonent.Element("Fee")),
                    new XElement(abonent.Element("LastPayment"))));
            }
        }

        public void Print()
        {
            
            foreach (var abonent in abonentInfoFiltered)
            {
                tableView.Text += $"{(string)abonent.Element("Name")}".PadRight(10) +
                    $"{(string)abonent.Element("Location")}".PadRight(10) +
                    $"{(string)abonent.Element("Address")}".PadRight(20) +
                    $"{(string)abonent.Element("Phone")}".PadRight(10) +
                    $"{(string)abonent.Element("ID")}".PadRight(10) +
                    $"{(string)abonent.Element("StartDate")}".PadRight(15) +
                    $"{(string)abonent.Element("LastPayment")}".PadRight(15) + Environment.NewLine;
            }
            tableView.Text += "".PadRight(90, '=') + Environment.NewLine;
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            DeleteItems DeleteItemForm = new DeleteItems();
            DeleteItemForm.DeleteItemEvent += new EventHandler<DeleteItemEventArgs>(OnDeleteChangeEvent);
            DeleteItemForm.Show();
        }

        private void OnDeleteChangeEvent(object sender, DeleteItemEventArgs e)
        {
            foreach (var abonent in abonentInfoFiltered)
                if ((string)abonent.Element("ID") == e.ID)
                {
                    abonentInfoFiltered.Remove(abonent);
                    Save();
                    Print();
                    return;
                }
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            xDoc.Save("newabonents.xml");
        }

        private void OnInsertClick(object sender, EventArgs e)
        {
            InsertItems InsertItemForm = new InsertItems();
            InsertItemForm.InsertItemEvent += new EventHandler<InsertItemEventArgs>(OnInsertChangeEvent);
            InsertItemForm.Show();
        }

        private void OnInsertChangeEvent(object sender, InsertItemEventArgs e)
        {
            XElement xElement = new XElement("AbonentInfo",
                new XElement("Name", e.abonent.Name),
                new XElement("Location", e.abonent.Location),
                new XElement("Address", e.abonent.Address),
                new XElement("Phone", e.abonent.Phone),
                new XElement("ID", e.abonent.ID),
                new XElement("StartDate", e.abonent.StartDate),
                new XElement("InstallationPayment", e.abonent.InstallationPayment),
                new XElement("Fee", e.abonent.Fee),
                new XElement("LastPayment", e.abonent.LastPayment));

            abonentInfoFiltered.Add(xElement);
            Save();
            Print();
        }

        private void XMLViewer_Load(object sender, EventArgs e)
        {
            
        }
    }
}