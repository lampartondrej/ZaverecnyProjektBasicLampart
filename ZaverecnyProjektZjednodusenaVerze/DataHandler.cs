using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektZjednodusenaVerze
{
    internal class DataHandler
    {
        Validator validator = new Validator();
        public Pojistenec ZiskejVsechnaData()
        {
            Console.Write("Zadej křestní jméno: ");
            string jmeno = validator.ValidujJmeno();

            Console.Write("\nZadej příjmení: ");
            string prijmeni = validator.ValidujPrijmeni();

            
            Console.Write("\nZadej věk pojištěnce: ");
            int vek = validator.ValidujVek();

            
            Console.Write("\nZadej telefonní číslo: ");
            string tel_cislo = validator.ValidujTelCislo();

            return new Pojistenec(jmeno, prijmeni, vek, tel_cislo);
        }

        public string ZiskejHledaneJmeno()
        {
            //pomocná string proměnná pro vyhledávání konkrétní shody pojistenec.Jmeno
            Console.WriteLine("Zadej jméno pojištěného: ");
            string hledaneJmeno = validator.ValidujJmeno();

            return hledaneJmeno;
        }

        public string ZiskejHledanePrijmeni()
        {
            //pomocná string proměnná pro vyhledávání konkrétní shody pojistenec.Prijmeni
            Console.WriteLine("Zadej příjmení pojištěbého: ");
            string hledanePrijmeni = validator.ValidujPrijmeni();

            return hledanePrijmeni;
        }
    }
}
