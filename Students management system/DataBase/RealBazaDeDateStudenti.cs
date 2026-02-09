using PROIECT_REFACUT_PAW.Entitati;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_REFACUT_PAW.Baza_de_date
{
    public static class RealBazaDeDateStudenti
    {


        private static string stringConnection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\YAN\Desktop\C# PROJECTS\PROIECT REFACUT PAW\RealDatBaseStudents.mdf"";Integrated Security = True";

        public static List<Disciplina> GetDisciplineByName(string denumireLista)
        {
            switch (denumireLista)
            {
                case "DisciplineAn1":
                    return DisciplineDB.DisciplineAn1;
                case "DisciplineAn2":
                    return DisciplineDB.DisciplineAn2;
                case "DisciplineAn3":
                    return DisciplineDB.DisciplineAn3;
                default:
                    return new List<Disciplina>(); 
            }
        }

        public static BindingList<Student> GetAllStudents()
        {
            var lista=new   BindingList<Student>();

            using(var conn=new SqlConnection(stringConnection ))
            {
                conn.Open();
                var cmd = new SqlCommand("select * from Studenti ", conn);
                var reader=cmd.ExecuteReader();
                while (reader.Read())
                {
                    var student = new Student()
                    {
                        Id = reader.GetInt32(0),
                        Nume = reader.GetString(1),
                        Prenume = reader.GetString(2),
                        AnStudiu = reader.GetInt32(3),
                        Serie = (Char)reader.GetString(4)[0],
                        Grupa = reader.GetInt32(5),
                        Discipline = GetDisciplineByName(reader.GetString(6))
                    };
                       lista.Add(student);
                }
            }

            return lista;
        }


    }
}
