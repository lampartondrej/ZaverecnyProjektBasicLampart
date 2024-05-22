using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektZjednodusenaVerze
{
    internal class LogikaPoSpusteni
    {
        private bool spusteno = true;

        DatabazePojistencu databazepojistencu = new DatabazePojistencu();
        
        public void Zahajit()
        {
            //Pro přidání nového pojištěnce zadej 1;
            //Pro zobrazení konkrétního pojištěnce zadej 2;
            //Pro zobrazení seznamu všech pojištěnců zadej 3;
            //Pro ukončení aplikace zadej 4;
            Menu menu = new Menu();
            menu.Zobraz();
            while (spusteno)
            {
                Console.WriteLine("Zadej číslo žádané operace: ");
                int operace;
                while(!int.TryParse(Console.ReadLine(), out operace))
                {
                    Console.WriteLine("Toto není validní příkaz!\nZadej číslo žádané operace: ");
                }
                switch (operace)
                {
                    case 1:
                        databazepojistencu.PridejPojistence();
                        Console.Clear();
                        menu.Zobraz();
                        break;
                    case 2:
                        databazepojistencu.VyhledejKonkretnihoPojistence();
                        Console.Clear();
                        menu.Zobraz();
                        break;
                    case 3:
                        databazepojistencu.ZobrazVsechnyPojistence();
                        Console.Clear();
                        menu.Zobraz();
                        break;
                    case 4:
                        spusteno = false;
                        break;
                    default:
                        Console.WriteLine("Toto není validní příkaz!");
                        Console.WriteLine("Zadej číslo žádané operace: ");
                        break;
                }
            }

        }
    }
}
