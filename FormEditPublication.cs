using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork4
{
     public partial class FormEditPublication : Form
    {
        public FormEditPublication(int n)
        {
            InitializeComponent();
            Research r = new Research();
            Program.ReadXML(r);
            PublicationNumberValue.Text = (n+1).ToString();
            tbStudentFirstName.Text = r.Publications[n].Student.FirstName;
            tbStudentLastName.Text = r.Publications[n].Student.LastName;
            DateTime dt;
            DateTime.TryParseExact(r.Publications[n].Student.EnrollmentYear.ToString(), "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);
            dtpEnrollmentYear.Value = dt;
            cmAchievement.DataSource = Enum.GetNames(typeof(ScientificAchievements));
            cmAchievement.SelectedItem = null;
            cmAchievement.SelectedItem = r.Publications[n].Type.ToString();
        }

        private void FormAddPublication_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason.ToString() == "3")
            {
                DialogResult result = MessageBox.Show("Чи потрібно записати внесені зміни?", "Закриття", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (tbStudentFirstName.Text != "" && tbStudentLastName.Text != "")
                    {
                        Research r = new Research();
                        Program.ReadXML(r);
                        r.Publications[int.Parse(PublicationNumberValue.Text)-1].EditPublication(tbStudentFirstName.Text, tbStudentLastName.Text, int.Parse(dtpEnrollmentYear.Value.ToString("yyyy")), (ScientificAchievements)Enum.Parse(typeof(ScientificAchievements), cmAchievement.Text));
                        Program.WriteXML(r);
                    }
                    else
                    {
                        MessageBox.Show("Зміни не могли бути збережені через неправильне введення інформації.");
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbStudentFirstName.Text!="" && tbStudentLastName.Text!="")
            {
                Research r = new Research();
                Program.ReadXML(r);
                r.Publications[int.Parse(PublicationNumberValue.Text)-1].EditPublication(tbStudentFirstName.Text, tbStudentLastName.Text, int.Parse(dtpEnrollmentYear.Value.ToString("yyyy")), (ScientificAchievements)Enum.Parse(typeof(ScientificAchievements), cmAchievement.Text));
                Program.WriteXML(r);
                this.Close();
            }
            else
            {
                MessageBox.Show("Зміни не можуть бути збережені через неправильне введення інформації. Перевірте введення.");
            }
        }

        private void btnCloseNoSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
