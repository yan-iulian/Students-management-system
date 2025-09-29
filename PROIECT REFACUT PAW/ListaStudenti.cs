using PROIECT_REFACUT_PAW.Baza_de_date;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROIECT_REFACUT_PAW.Entitati;

namespace PROIECT_REFACUT_PAW
{
    public partial class ListaStudentiForm : Form
    {
        public ListaStudentiForm()
        {
            InitializeComponent();
            studentGridView.CellFormatting += studentGridView_CellFormatting;
            studentGridView.AutoGenerateColumns = false;
            studentGridView.DataSource = FakeDataBase.Studenti;

            //studentGridView.DataSource = RealBazaDeDateStudenti.GetAllStudents();

            AddTextBoxColumn("Id", "Id");
            AddTextBoxColumn("Nume", "Nume");
            AddTextBoxColumn("Prenume", "Prenume");
            AddTextBoxColumn("AnStudiu", "An studiu");
            AddTextBoxColumn("Serie", "Serie");
            AddTextBoxColumn("Grupa", "Grupa");
            AddButtonColumn("Afiseaza discipline", "➡️", "afiseazaDiscipline");
            AddButtonColumn("Editeaza", "✏️", "editeazaStudentul");
            AddButtonColumn("Pagina\npersonala", "🆔", "acceseazaPP");
        }


        private void AddTextBoxColumn(string propertyName, string headerText, int width = 100, bool isVisible = true)
        {
            var column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = propertyName;
            column.HeaderText = headerText;
            column.Width = width;
            column.Name = propertyName;
            column.Visible = isVisible;
            studentGridView.Columns.Add(column);
        }

        private void AddButtonColumn(string headerText, string buttonText, string columnName)
        {
            var column = new DataGridViewButtonColumn();
            column.HeaderText = headerText;
            column.Text = buttonText;
            column.UseColumnTextForButtonValue = true;
            column.Name = columnName;
            studentGridView.Columns.Add(column);
        }

        //colorare celule
        private void studentGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                
                string searchText = searchTextBox.Text.Trim().ToLower();
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    
                    var student = FakeDataBase.Studenti[e.RowIndex];

                    switch (student.AnStudiu)
                    {
                        case 1:
                            studentGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Lavender;
                            break;
                        case 2:
                            studentGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
                            break;
                        case 3:
                            studentGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PowderBlue;
                            break;
                        default:
                            studentGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; 
                            break;
                    }
                }
                else
                {
                   
                    studentGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }



        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
               
                if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                
                var student = FakeDataBase.Studenti[e.RowIndex];

              
                var disciplineForm = new DisciplineViewForm(student);
                disciplineForm.ShowDialog();
            }

            if (e.RowIndex>=0 && e.ColumnIndex==7)
            {
                var student = FakeDataBase.Studenti[e.RowIndex];
                var editForm = new EditeazaStudentForm(student);

                editForm.ShowDialog();
                studentGridView.DataSource = null;
                studentGridView.DataSource=FakeDataBase.Studenti;
              //  studentGridView.DataSource = RealBazaDeDateStudenti.GetAllStudents();

                
            }

            if(e.RowIndex>=0 && e.ColumnIndex == 8)
            {
                var student = FakeDataBase.Studenti[e.RowIndex];
                var paginaPersonalaForm = new PaginaPersonalaForm(student);
                paginaPersonalaForm.ShowDialog();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adaugaStudentButton_Click(object sender, EventArgs e)
        {
            var addStud = new AddStudentForm();
            addStud.ShowDialog();
            studentGridView.DataSource = null;
            studentGridView.DataSource = Baza_de_date.FakeDataBase.Studenti;
            //studentGridView.DataSource=Baza_de_date.RealDataBase.GetAllStudents();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

            string searchText = searchTextBox.Text.ToLower();

            var studentiFiltrati = FakeDataBase.Studenti
                .Where(s => s.Nume.ToLower().Contains(searchText) || s.Prenume.ToLower().Contains(searchText)|| s.AnStudiu.ToString() == searchText)
                .ToList();

            studentGridView.DataSource = null;
            studentGridView.DataSource = studentiFiltrati;
            

        }

        private void serializareButton_Click(object sender, EventArgs e)
        {
            var bf = new BinaryFormatter();
            using (var text = new FileStream("Studenti.dat", FileMode.OpenOrCreate))
            {
                bf.Serialize(text, FakeDataBase.Studenti);
                MessageBox.Show("Serializarea s-a realizat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deserializareButton_Click(object sender, EventArgs e)
        {
            var bf=new BinaryFormatter();
            var textbinar = new FileStream("Studenti.dat", FileMode.Open);
            FakeDataBase.Studenti = (List<Student>)bf.Deserialize(textbinar);
        }

    }
}
