using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_REFACUT_PAW.Baza_de_date
{
    public class FakeDataBaseSali
    {
        public static List<int> Sali = GenerateSali();

        private static List<int> GenerateSali()
        {
            var sali = new List<int>();

            for (int etaj = 0; etaj <= 6; etaj++) 
            {
                int prefix = 20 + etaj; 
                for (int i = 0; i <= 20; i++)
                {
                    int sala = prefix * 100 + i; 
                    sali.Add(sala);
                }
            }

            return sali;
        }
    }
}
