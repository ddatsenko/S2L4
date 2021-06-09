using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork4
{
    public partial class FormAddPublication : Form
    {
        public FormAddPublication()
        {
            InitializeComponent();
            cmAchievement.DataSource = Enum.GetNames(typeof(ScientificAchievements));
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
                        r.AddPublication(tbStudentFirstName.Text, tbStudentLastName.Text, int.Parse(dtpEnrollmentYear.Value.ToString("yyyy")), (ScientificAchievements)Enum.Parse(typeof(ScientificAchievements), cmAchievement.Text));
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
                r.AddPublication(tbStudentFirstName.Text, tbStudentLastName.Text, int.Parse(dtpEnrollmentYear.Value.ToString("yyyy")), (ScientificAchievements)Enum.Parse(typeof(ScientificAchievements), cmAchievement.Text));
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
