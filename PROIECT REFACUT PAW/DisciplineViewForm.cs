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
    public partial class DisciplineViewForm : Form
    {
        private Student _student;
        public DisciplineViewForm(Student student)
        {
            InitializeComponent();
            _student = student;
            LoadStudentDisciplines(student);
        }
        private void LoadStudentDisciplines(Student student)
        {
            DisciplineGridView.Rows.Clear();
            DisciplineGridView.Columns.Clear();


            AddTextBoxColumn("Denumire", "Denumire");
            AddTextBoxColumn("Credite", "Credite");
            AddCheckBoxColumn("eVerificare", "Verificare");
            AddButtonColumn("Afiseaza detaliile", "🗓️", "afiseazaDetalii");

            List<Disciplina> discipline = new List<Disciplina>();

            if (student.AnStudiu == 1)
                discipline = DisciplineDB.DisciplineAn1;
            else if (student.AnStudiu == 2)
                discipline = DisciplineDB.DisciplineAn2;
            else discipline = DisciplineDB.DisciplineAn3;

            foreach (var disciplina in discipline)
            {
                var row = new DataGridViewRow();

               
                row.Cells.Add(new DataGridViewTextBoxCell { Value = disciplina.Denumire });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = disciplina.Credite.ToString() });
                row.Cells.Add(new DataGridViewCheckBoxCell { Value = disciplina.eVerificare });

                
                DisciplineGridView.Rows.Add(row);
            }
        }

        private void AddTextBoxColumn(string propertyName, string headerText, int width = 100, bool isVisible = true)
        {
            var column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = propertyName;
            column.HeaderText = headerText;
            column.Width = width;
            column.Name = propertyName;
            column.Visible = isVisible;
            DisciplineGridView.Columns.Add(column);
        }
        private void AddCheckBoxColumn(string propertyName, string headerText, int width = 100)
        {
            var column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = propertyName;
            column.HeaderText = headerText;
            column.Width = width;
            column.Name = propertyName;
            column.ReadOnly = true;
            DisciplineGridView.Columns.Add(column);
        }

        private void AddButtonColumn(string headerText, string buttonText, string columnName)
        {
            var column = new DataGridViewButtonColumn();
            column.HeaderText = headerText;
            column.Text = buttonText;
            column.UseColumnTextForButtonValue = true;
            column.Name = columnName;
            DisciplineGridView.Columns.Add(column);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisciplineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex==3)
            {
                var disciplina = _student.Discipline[e.RowIndex].Denumire;

                var random = new Random();

                
                var profesor = FakeDataBaseProfesori.Profesori[random.Next(FakeDataBaseProfesori.Profesori.Count)];

                
                var luniPermise = new[] { 1, 2, 5, 6 };
                int luna = luniPermise[random.Next(luniPermise.Length)];
                int zi = random.Next(1, 30);
                var data = new DateTime(DateTime.Now.Year, luna, zi);

               
                var ore = new[] { "08:00", "08:30","09:30","09:00","10:00","10:30","11:00","11:30","12:00","12:30", "13:00","13:30"
                , "14:00","14:30","15:00","15:30","16:00","16:30","17:00","17:30","18:00","18:30","19:00" };
                var ora = ore[random.Next(ore.Length)];

                
                var sala = FakeDataBaseSali.Sali[random.Next(FakeDataBaseSali.Sali.Count)];

                string mesaj = $"Examen: {disciplina}\n" +
                               $"Profesor: {profesor}\n" +
                               $"Data: {data:dd MMMM yyyy}\n" +
                               $"Ora: {ora}\n" +
                               $"Sala: {sala}";

                MessageBox.Show(mesaj, "Detalii Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
