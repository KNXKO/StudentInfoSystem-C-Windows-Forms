using Microsoft.VisualBasic;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lukas_Lechovic_06
{
    internal class Student
    {
        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public DateTime Datum_narodenia { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Bydlisko { get; set; }
        public string PSC { get; set; }

        public Student(string meno, string priezvisko, DateTime datum_narodenia, string email, string telefon, string bydlisko, string psc)
        {
            Meno = meno;
            Priezvisko = priezvisko;
            Datum_narodenia = datum_narodenia;
            Email = email;
            Telefon = telefon;
            Bydlisko = bydlisko;
            PSC = psc;
        }
    }
}
