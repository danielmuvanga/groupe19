using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Abstract;
using System.Data.SqlClient;
using TP2.Connection;
using System.Data;
using MySql.Data.MySqlClient;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CLASSES ABSTRAITES");
            Console.WriteLine("-----------------------------------\n");

            Teacher enseignant1 = new Teacher("Mitamba", "", "Benedicte");
            Student etudiant1 = new Student("Bibundo", "Banyere", "22liagelj");

            enseignant1.Ajouter(2);
            etudiant1.Ajouter(2);

            enseignant1.Afficher(1, 2);
            Console.WriteLine("\n-----------------------------------\n");
            etudiant1.Afficher(1, 2);

            Console.WriteLine("\n-----------------------------------\n");
            
            Console.WriteLine("INTERFACES");
            Console.WriteLine("-----------------------------------\n");

            Interfaces.Teacher enseignant2 = new Interfaces.Teacher("ff", "yy", "ljk");
            Interfaces.Student etudiant2 = new Interfaces.Student("kdkd", "hshs", "24242");

            enseignant2.Ajouter(2);
            etudiant2.Ajouter(2);

            enseignant2.Afficher(2, 2);
            Console.WriteLine("\n-----------------------------------\n");
            etudiant2.Afficher(2, 2);

            Console.WriteLine("\n-----------------------------------\n");

            Console.ReadLine();
        }
    }
}
