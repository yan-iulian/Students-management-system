using PROIECT_REFACUT_PAW.Baza_de_date;
using PROIECT_REFACUT_PAW.Entitati;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROIECT_REFACUT_PAW
{
    public partial class EditeazaStudentForm : Form
    {
        private Student _student;

        public EditeazaStudentForm(Student student)
        {
            InitializeComponent();
            _student = student;

            
            IdNumeric.Value = _student.Id;
            numeTextBox.Text = _student.Nume;
            prenumeTextBox.Text = _student.Prenume;
            

            
            IdNumeric.ReadOnly = true;
            numeTextBox.ReadOnly = true;
            prenumeTextBox.ReadOnly = true;

            DisableNumeric(IdNumeric);
            DisableTextBox(numeTextBox);
            DisableTextBox(prenumeTextBox);
        }

        private void DisableTextBox(System.Windows.Forms.TextBox textBox)
        {
            
            textBox.Enabled = false; 
            textBox.BackColor = SystemColors.Control; 
            textBox.BorderStyle = BorderStyle.None; 
            textBox.ForeColor = SystemColors.GrayText; 
        }

        private void DisableNumeric(System.Windows.Forms.NumericUpDown n)
        {
            
            n.Enabled = false; 
            n.BackColor = SystemColors.Control; 
            n.BorderStyle = BorderStyle.None; 
            n.ForeColor = SystemColors.GrayText; 
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int nouAn = (int)anDeStudiuNumeric.Value;

            if (_student.AnStudiu != nouAn)
            {
                _student.AnStudiu = nouAn;

                
                if (nouAn == 1)
                    _student.Discipline = DisciplineDB.DisciplineAn1;
                else if (nouAn == 2)
                    _student.Discipline = DisciplineDB.DisciplineAn2;
                else
                    _student.Discipline = DisciplineDB.DisciplineAn3;
            }

            MessageBox.Show("Studentul a fost editat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var confirmare = MessageBox.Show("Ești sigur că vrei să ștergi acest student?", "Confirmare ștergere",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmare == DialogResult.Yes)
            {
                // Ștergere din baza de date falsă
                FakeDataBase.Studenti.Remove(_student);

                MessageBox.Show("Studentul a fost șters cu succes!", "Șters", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK; // Pentru a notifica formularul părinte
                Close();
            }
        }
    }
}
