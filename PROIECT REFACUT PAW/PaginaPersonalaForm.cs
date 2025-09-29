using PROIECT_REFACUT_PAW.Baza_de_date;
using PROIECT_REFACUT_PAW.Entitati;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Data.SqlClient;

namespace PROIECT_REFACUT_PAW
{
    public partial class PaginaPersonalaForm : Form
    {
        private Student _student;

        public PaginaPersonalaForm(Student student)
        {
            InitializeComponent();
            _student = student;
            LoadStudentPersonalPage(_student);
        }


        private void LoadStudentPersonalPage(Student student)
        {
            // Setăm numele studentului
            numeStudentLabel.Text = $"{student.Nume} {student.Prenume}";

            Random random=  new Random();
            string[] raspuns = new string[]{ "DA", "NU" };
            string rezultat=raspuns[random.Next(0, raspuns.Length)];

            raspunsLabel.Text = rezultat;

            afiseazaButton.Visible = false;
            if(rezultat=="DA")
            {
               afiseazaButton.Visible=true;
            }



            
            mediileDataGridView.Rows.Clear();
            mediileDataGridView.Columns.Clear();

            mediileDataGridView.Columns.Add("an", "An");
            mediileDataGridView.Columns.Add("medie", "Medie");

            // Verificăm anul în care este studentul și adăugăm mediile
            if (student.AnStudiu == 1)
            {
                mediileDataGridView.Rows.Add("An 1", GetRandomMedie(7, 10)); 
                mediileDataGridView.Rows.Add("An 2", "-"); 
                mediileDataGridView.Rows.Add("An 3", "-"); 
            }
            else if (student.AnStudiu == 2)
            {
                mediileDataGridView.Rows.Add("An 1", GetRandomMedie(4, 10)); 
                mediileDataGridView.Rows.Add("An 2", GetRandomMedie(3, 10)); 
                mediileDataGridView.Rows.Add("An 3", "-"); // 0 pentru Anul 3
            }
            else // Anul 3
            {
                mediileDataGridView.Rows.Add("An 1", GetRandomMedie(8, 10)); 
                mediileDataGridView.Rows.Add("An 2", GetRandomMedie(7, 10)); 
                mediileDataGridView.Rows.Add("An 3", GetRandomMedie(9, 10)); 
            }
        }

       
        private double GetRandomMedie(double min, double max)
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * (max - min) + min, 2); // Generăm medii cu 2 zecimale
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void genereazaDateleTxt_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            double mediaAn1 = Math.Round(6 + rnd.NextDouble() * 4, 2);
            double mediaAn2 = Math.Round(6 + rnd.NextDouble() * 4, 2);
            double mediaAn3 = Math.Round(6 + rnd.NextDouble() * 4, 2);

            // Dacă studentul nu e în anul 3, setăm restul pe 0
            if (_student.AnStudiu == 1)
            {
                mediaAn2 = 0;
                mediaAn3 = 0;
            }
            else if (_student.AnStudiu == 2)
            {
                mediaAn3 = 0;
            }

            var lines = new List<string>
            {
                $"Nume: {_student.Nume} {_student.Prenume}",
                $"An de studiu: {_student.AnStudiu}",
                $"Media Anul 1: {mediaAn1}",
                $"Media Anul 2: {mediaAn2}",
                $"Media Anul 3: {mediaAn3}"
            };

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{_student.Nume}_{_student.Prenume}_media.txt");
            File.WriteAllLines(path, lines);

            MessageBox.Show("Fișier generat cu succes pe desktop!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void genAdeverintaButton_Click(object sender, EventArgs e)
        {
            
            int anUniversitar = 2024;
            int semestru = 1;

           
            string facultate = "Facultatea de Cibernetica, Statistica si Informatica Economica";
            string tipStudii = "Studii cu frecvență";
            string decanFacultate = "Prof. univ. dr. Claudiu HERȚELIU";
            string anStudiu = _student.AnStudiu == 1 ? "Anul 1" : _student.AnStudiu == 2 ? "Anul 2" : "Anul 3";

            
            var lines = new List<string>
               {
                               "                                                                                     ADEVERINȚĂ",
                "\n\n\n",
                $"Subsemnatul(a) {facultate},",
                $"certific că, studentul { _student.Nume} {_student.Prenume},",
                $"înmatriculat(ă) în anul universitar {anUniversitar}-{anUniversitar + 1},",
                $"în cadrul programului de studii {tipStudii},",
                $"se află în prezent în {anStudiu}.",
                "\n\n",
                $"Această adeverință este emisă la cererea studentului, pentru {(_student.AnStudiu == 1 ? "inscrierea la examenul de finalizare" : "continuarea studiilor")},",
                $"fiind valabilă până la finalul anului universitar {anUniversitar}-{anUniversitar + 1}.",
                "\n\n",
                $"Eliberată astăzi, {DateTime.Now.ToString("dd.MM.yyyy")}.",
                "\n\n\n\n\n",
                "Semnătura,",
                "_________________________________",
                "                                                                                     Decan Facultate",
               $"                                                                                          {decanFacultate}         "
                };

            
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{_student.Nume}_{_student.Prenume}_adeverinta.txt");
            File.WriteAllLines(path, lines);

            MessageBox.Show("Adeverința a fost generată cu succes pe desktop!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void afiseazaButton_Click(object sender, EventArgs e)
        {

            List<string> camine = FakeDataBaseCamine.Camine;

            
            Random random = new Random();
            var camineAmestecate = camine.OrderBy(x => random.Next()).ToList(); 

            StringBuilder mesaj = new StringBuilder("Opțiunile disponibile pentru cămin:\n");

            
            for (int i = 0; i < camineAmestecate.Count; i++)
            {
                mesaj.AppendLine($"Opțiunea {i + 1}:\t {camineAmestecate[i]}");
            }

            
            MessageBox.Show(mesaj.ToString(), "Opțiuni Cămin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
