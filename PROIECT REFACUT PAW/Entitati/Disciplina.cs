using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_REFACUT_PAW.Entitati
{
    [Serializable]
    public class Disciplina
    {
        public int ID { get; set; }
        public string Denumire { get; set; }
        public int Credite { get; set; }
        public bool eVerificare { get; set; }
    }
}


