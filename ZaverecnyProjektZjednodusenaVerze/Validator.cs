using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektZjednodusenaVerze
{
    internal class Validator
    {
        private string jmeno = "";

        private string prijmeni = "";

        private int vek = 0;

        private string telcislo = "";
        public string ValidujJmeno()
        {
            jmeno = Console.ReadLine().Trim();
            if (!jmeno.All(char.IsLetter))
            {
                Console.WriteLine("Prosím nezadávejte do jména číslice!\nZadej křestní jméno: ");
                ValidujJmeno();
            }
            if (jmeno.Length == 0)
            {
                Console.WriteLine("Toto pole je povinný údaj!\nZadej křestní jméno: ");
                ValidujJmeno();
            }
            return jmeno;
        }

        public string ValidujPrijmeni()
        {
            prijmeni = Console.ReadLine().Trim();
            if (!prijmeni.All(char.IsLetter))
            {
                Console.WriteLine("Prosím nezadávejte do příjmení číslice!\nZadej příjmení: ");
                ValidujPrijmeni();
            }
            if (prijmeni.Length == 0)
            {
                Console.WriteLine("Toto pole je povinný údaj!\nZadej příjmení: ");
                ValidujPrijmeni();
            }
            return prijmeni;
        }

        public int ValidujVek()
        {
            while(!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Prosím zadejte věk formou číslic od 0 do 150!");
            if ((vek < 0)||(vek > 150))
            {
                Console.WriteLine("Zadaný věk je příliš vysoký, nebo příliš nízký, prosím zadejte pouze číslice od 0 do 150");
                ValidujVek();
            }
            return vek;
        }

        public string ValidujTelCislo()
        {
            telcislo = Console.ReadLine().Trim();
            if (telcislo.All(char.IsLetter))
            {
                Console.WriteLine("Telefonní číslo musí obsahovat pouze číslice a musí být vyplněné!\nZadej telefonní číslo: ");
                ValidujTelCislo();
            }
            if (telcislo.Length > 15)
            {
                Console.WriteLine("Telefonní číslo přesahuje maximální délku. Maximální povolená délka znaků je 15!\nZadejte telefonní číslo: ");
                ValidujTelCislo();
            }
            return telcislo;
        }
    }
}
