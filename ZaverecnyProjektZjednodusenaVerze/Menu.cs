using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektZjednodusenaVerze
{
    //Metoda zobrazuje grafické rozhraní Menu, slouží jako jakési UI v prostředí konzole
    internal class Menu
    {
        public void Zobraz()
        {
            Console.WriteLine(" _____         _         ___                                                  \r\n| ____| _ __  (_)  ___  |_ _| _ __   ___  _   _  _ __  __ _  _ __    ___  ___ \r\n|  _|  | '_ \\ | | / __|  | | | '_ \\ / __|| | | || '__|/ _` || '_ \\  / __|/ _ \\\r\n| |___ | |_) || || (__   | | | | | |\\__ \\| |_| || |  | (_| || | | || (__|  __/\r\n|_____|| .__/ |_| \\___| |___||_| |_||___/ \\__,_||_|   \\__,_||_| |_| \\___|\\___|\r\n       |_|                                                                    \r\n  ____                                              \r\n / ___| ___   _ __ ___   _ __    __ _  _ __   _   _ \r\n| |    / _ \\ | '_ ` _ \\ | '_ \\  / _` || '_ \\ | | | |\r\n| |___| (_) || | | | | || |_) || (_| || | | || |_| |\r\n \\____|\\___/ |_| |_| |_|| .__/  \\__,_||_| |_| \\__, |\r\n                        |_|                   |___/ ");
            Console.WriteLine("Vítej v aplikaci naší pojišťovny");
            Console.WriteLine("Pro pokračování zvol jednu z následujícívch operací: ");
            Console.WriteLine("\nPro přidání nového pojištěnce zadej 1");
            Console.WriteLine("Pro zobrazení konkrétního pojištěnce zadej 2");
            Console.WriteLine("Pro zobrazení seznamu všech pojištěnců zadej 3");
            Console.WriteLine("Pro ukončení aplikace zadej 4");
            Console.WriteLine("=======================================================");
        }
    }
}
