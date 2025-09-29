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

namespace PROIECT_REFACUT_PAW
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student
                {
                    Id = Convert.ToInt32(IdNumeric.Value),
                    Nume = numeTextBox.Text,
                    Prenume = prenumeTextBox.Text,
                    AnStudiu = Convert.ToInt32(anDeStudiuNumeric.Value),
                    Serie = serieTextBox.Text[0],
                    Grupa = Convert.ToInt32(grupaNumeric.Value)
                };
                if (student.AnStudiu == 1)
                    student.Discipline = DisciplineDB.DisciplineAn1;
                else if (student.AnStudiu == 2)
                    student.Discipline = DisciplineDB.DisciplineAn2;
                else student.Discipline = DisciplineDB.DisciplineAn3;

                try
                {
                    FakeDataBase.Studenti.Add(student);
                    MessageBox.Show("Studentul a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare,{ex.Message}");
            }
        }

       
    }
}
