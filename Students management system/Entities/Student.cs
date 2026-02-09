using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_REFACUT_PAW.Entitati
{
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int AnStudiu { get; set; }
        public char Serie { get; set; }
        public int Grupa { get; set; }
        public List<Disciplina> Discipline = new List<Disciplina>();
    }
}
