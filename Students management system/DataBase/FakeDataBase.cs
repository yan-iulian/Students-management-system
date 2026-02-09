using PROIECT_REFACUT_PAW.Entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_REFACUT_PAW.Baza_de_date
{
    public static class FakeDataBase
    {
        public static List<Student> Studenti = new List<Student>()
        {
            new Student
            {
                Id = 1,
                Nume = "Popescu",
                Prenume = "Andrei",
                AnStudiu = 1,
                Serie = 'A',
                Grupa = 1013,
                Discipline = DisciplineDB.DisciplineAn1
            },
            new Student
            {
                Id = 2,
                Nume = "Ionescu",
                Prenume = "Maria",
                AnStudiu = 1,
                Serie = 'B',
                Grupa = 1012,
                Discipline = DisciplineDB.DisciplineAn1
            },
            new Student
            {
                Id = 3,
                Nume = "Vasilescu",
                Prenume = "Ion",
                AnStudiu = 2,
                Serie = 'D',
                Grupa = 1060,
                Discipline = DisciplineDB.DisciplineAn2
            },
            new Student
            {
                Id = 4,
                Nume = "Georgescu",
                Prenume = "Elena",
                AnStudiu = 2,
                Serie = 'D',
                Grupa = 1059,
                Discipline = DisciplineDB.DisciplineAn2
            },
            new Student
            {
                Id = 5,
                Nume = "Mihai",
                Prenume = "Gabriel",
                AnStudiu = 3,
                Serie = 'B',
                Grupa = 1085,
                Discipline = DisciplineDB.DisciplineAn3
            },
            new Student
        {
            Id = 6,
            Nume = "Ionescu",
            Prenume = "Maria",
            AnStudiu = 1,
            Serie = 'B',
            Grupa = 1014,
            Discipline = DisciplineDB.DisciplineAn1
        },
        new Student
        {
            Id = 7,
            Nume = "Dumitrescu",
            Prenume = "George",
            AnStudiu = 1,
            Serie = 'A',
            Grupa = 1015,
            Discipline = DisciplineDB.DisciplineAn1
        },
        new Student
        {
            Id = 8,
            Nume = "Radu",
            Prenume = "Elena",
            AnStudiu = 1,
            Serie = 'C',
            Grupa = 1016,
            Discipline = DisciplineDB.DisciplineAn1
        },
        new Student
        {
            Id = 9,
            Nume = "Tudor",
            Prenume = "Alexandru",
            AnStudiu = 2,
            Serie = 'A',
            Grupa = 1056,
            Discipline = DisciplineDB.DisciplineAn2
        },
        new Student
        {
            Id = 10,
            Nume = "Marin",
            Prenume = "Ioana",
            AnStudiu = 2,
            Serie = 'B',
            Grupa = 1055,
            Discipline = DisciplineDB.DisciplineAn2
        },
        new Student
        {
            Id = 11,
            Nume = "Stefan",
            Prenume = "Mihai",
            AnStudiu = 2,
            Serie = 'C',
            Grupa = 1057,
            Discipline = DisciplineDB.DisciplineAn2
        },
        new Student
        {
            Id = 13,
            Nume = "Lazar",
            Prenume = "Bianca",
            AnStudiu = 3,
            Serie = 'A',
            Grupa = 1087,
            Discipline = DisciplineDB.DisciplineAn3
        },
        new Student
        {
            Id = 13,
            Nume = "Dobre",
            Prenume = "Razvan",
            AnStudiu = 3,
            Serie = 'B',
            Grupa =1088,
            Discipline = DisciplineDB.DisciplineAn3
        },
        new Student
        {
            Id = 14,
            Nume = "Enache",
            Prenume = "Cristina",
            AnStudiu = 3,
            Serie = 'C',
            Grupa = 1089,
            Discipline = DisciplineDB.DisciplineAn3
        },
        new Student
        {
            Id = 15,
            Nume = "Nistor",
            Prenume = "Florin",
            AnStudiu = 3,
            Serie = 'A',
            Grupa = 1087,
            Discipline = DisciplineDB.DisciplineAn3
        },
                new Student
        {
            Id = 16,
            Nume = "Stoica",
            Prenume = "Andreea",
            AnStudiu = 1,
            Serie = 'A',
            Grupa = 1005,
            Discipline = DisciplineDB.DisciplineAn1
        },
        new Student
        {
            Id = 17,
            Nume = "Badea",
            Prenume = "Paul",
            AnStudiu = 1,
            Serie = 'B',
            Grupa = 1010,
            Discipline = DisciplineDB.DisciplineAn1
        },
        new Student
        {
            Id = 18,
            Nume = "Neagu",
            Prenume = "Roxana",
            AnStudiu = 2,
            Serie = 'C',
            Grupa = 1055,
            Discipline = DisciplineDB.DisciplineAn2
        },
        new Student
        {
            Id = 19,
            Nume = "Ilie",
            Prenume = "David",
            AnStudiu = 2,
            Serie = 'A',
            Grupa = 1063,
            Discipline = DisciplineDB.DisciplineAn2
        },
        new Student
        {
            Id = 20,
            Nume = "Matei",
            Prenume = "Laura",
            AnStudiu = 3,
            Serie = 'B',
            Grupa = 1080,
            Discipline = DisciplineDB.DisciplineAn3
        },
        new Student
        {
            Id = 21,
            Nume = "Barbu",
            Prenume = "Cristian",
            AnStudiu = 3,
            Serie = 'C',
            Grupa = 1090,
            Discipline = DisciplineDB.DisciplineAn3
        },
        new Student
        {
            Id = 22,
            Nume = "Dragomir",
            Prenume = "Teodora",
            AnStudiu = 1,
            Serie = 'C',
            Grupa = 1030,
            Discipline = DisciplineDB.DisciplineAn1
        },
        new Student
        {
            Id = 23,
            Nume = "Serban",
            Prenume = "Marius",
            AnStudiu = 2,
            Serie = 'B',
            Grupa = 1067,
            Discipline = DisciplineDB.DisciplineAn2
        },
        new Student
        {
            Id = 24,
            Nume = "Preda",
            Prenume = "Ana",
            AnStudiu = 3,
            Serie = 'A',
            Grupa = 1075,
            Discipline = DisciplineDB.DisciplineAn3
        },
        new Student
        {
            Id = 25,
            Nume = "Voicu",
            Prenume = "Stefan",
            AnStudiu = 3,
            Serie = 'B',
            Grupa = 1085,
            Discipline = DisciplineDB.DisciplineAn3
        },
        new Student
            {
                Id = 26,
                Nume = "Lupu",
                Prenume = "Bianca",
                AnStudiu = 1,
                Serie = 'A',
                Grupa = 1008,
                Discipline = DisciplineDB.DisciplineAn1
            },
            new Student
            {
                Id = 27,
                Nume = "Tudor",
                Prenume = "Alex",
                AnStudiu = 1,
                Serie = 'B',
                Grupa = 1022,
                Discipline = DisciplineDB.DisciplineAn1
            },
            new Student
            {
                Id = 28,
                Nume = "Dumitru",
                Prenume = "Georgiana",
                AnStudiu = 2,
                Serie = 'C',
                Grupa = 1058,
                Discipline = DisciplineDB.DisciplineAn2
            },
            new Student
            {
                Id = 29,
                Nume = "Enache",
                Prenume = "Robert",
                AnStudiu = 2,
                Serie = 'A',
                Grupa = 1069,
                Discipline = DisciplineDB.DisciplineAn2
            },
            new Student
            {
                Id = 30,
                Nume = "Moraru",
                Prenume = "Irina",
                AnStudiu = 3,
                Serie = 'C',
                Grupa = 1082,
                Discipline = DisciplineDB.DisciplineAn3
            },
            new Student
            {
                Id = 31,
                Nume = "Grigore",
                Prenume = "Lucian",
                AnStudiu = 3,
                Serie = 'A',
                Grupa = 1091,
                Discipline = DisciplineDB.DisciplineAn3
            },
            new Student
            {
                Id = 32,
                Nume = "Marcu",
                Prenume = "Delia",
                AnStudiu = 1,
                Serie = 'B',
                Grupa = 1012,
                Discipline = DisciplineDB.DisciplineAn1
            },
            new Student
            {
                Id = 33,
                Nume = "Zamfir",
                Prenume = "Andrei",
                AnStudiu = 2,
                Serie = 'B',
                Grupa = 1065,
                Discipline = DisciplineDB.DisciplineAn2
            },
            new Student
            {
                Id = 34,
                Nume = "Petrache",
                Prenume = "Oana",
                AnStudiu = 3,
                Serie = 'C',
                Grupa = 1089,
                Discipline = DisciplineDB.DisciplineAn3
            },
            new Student
            {
                Id = 35,
                Nume = "Rusu",
                Prenume = "Mihnea",
                AnStudiu = 2,
                Serie = 'A',
                Grupa = 1051,
                Discipline = DisciplineDB.DisciplineAn2
            }



        };

    }
}
