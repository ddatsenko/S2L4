using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LabWork4
{
    partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            Student s = new Student("A", "B", 2021);
            Publication p = new Publication(s, ScientificAchievements.InternationalConference);
            Customer c = new Customer("CName", "Topic", 99999);
            Research r = new Research(c, DateTime.Now);
            r.AddPublication(p);
            r.AddPublication(p);
            r.AddPublication(p);
            r.AddPublication(p);
            r.AddPublication(p);
            r.AddPublication(p);
            r.AddPublication(p);

            Program.WriteXML(r);
            LoadData();
           
        }

        public void LoadData ()
        {
            Research r = new Research();
            Program.ReadXML(r);

            LoadBigData(r);
            LoadShortData(r);
        }

        public void LoadBigData(Research r)
        {
            CompanyNameValue.Text = r.Customer.CompanyName;
            ResearchTopicValue.Text = r.Customer.ResearchTopic;
            CostValue.Text = r.Customer.Cost.ToString();
            DateValue.Text = r.Date.ToString("dd/MM/yyyy");
            PublicationsListBox.Items.Clear();
            foreach (Publication p in r.Publications)
            {
                string st = String.Format("{0} {1} ({2}), {3}", p.Student.FirstName, p.Student.LastName, p.Student.EnrollmentYear, ScientificAchievementsProcessor.ToDescriptionSring(p.Type));
                PublicationsListBox.Items.Add(st);
            }
        }

        public void LoadShortData(Research r)
        {
            ShortDataValue.Text = r.ToShortString();
        }

        private void PublicationSelected(object sender, EventArgs e)
        {
            if (PublicationsListBox.SelectedIndex == -1)
            {
                btnEditPublication.Enabled = false;
            }
            else
            {
                btnEditPublication.Enabled = true;
            }
        }

        private void btnEditPublication_Click(object sender, EventArgs e)
        {
            FormEditPublication form = new FormEditPublication(PublicationsListBox.SelectedIndex);
            form.ShowDialog();
            LoadData();
        }

        private void btnAddPublication_Click(object sender, EventArgs e)
        {
            FormAddPublication form = new FormAddPublication();
            form.ShowDialog();
            LoadData();
        }
    }
}
