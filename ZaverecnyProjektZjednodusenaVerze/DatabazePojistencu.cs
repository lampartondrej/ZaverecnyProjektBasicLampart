using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektZjednodusenaVerze
{
    internal class DatabazePojistencu
    {
        //inicializace kolekce pojištěnců
        List<Pojistenec> pojistenci;
        DataHandler datahandler;

        public DatabazePojistencu()
        {
            pojistenci = new List<Pojistenec>();
            datahandler = new DataHandler();
        }

        //metoda přidává pojištěnce do kolekce pojištěnců
        public void PridejPojistence()
        {
            Pojistenec novyPojistenec = datahandler.ZiskejVsechnaData();
            pojistenci.Add(novyPojistenec);

            Console.WriteLine("Data byla uložena, pokračujte libovolnou klávesou...");

            Console.ReadKey();
        }
        //Metoda vyhledává konkrétního pojištěnce v kolekci. Metoda si po vyvolání vyžádá zadat přesně jméno a příjmení pojištěnce.
        //Nenalezne-li shodu vrátí chybovou hlášku a nabídne zadání zopakovat. V případě že uživatel zvolí ano, nebo nezadá příkaz správně, metoda se zavolá rekurzivně.
        public void VyhledejKonkretnihoPojistence()
        {
            string hledaneJmeno = datahandler.ZiskejHledaneJmeno();
            string hledanePrijmení = datahandler.ZiskejHledanePrijmeni();
            
            var dotaz = from po in pojistenci
                        where ((po.Jmeno == hledaneJmeno) && (po.Prijmeni == hledanePrijmení))
                        select po;
            foreach (Pojistenec po in dotaz )
            {
                Console.WriteLine(po);
                Console.WriteLine("Pokračujte libovonou klávesou...");
                Console.ReadKey();
            }

            if(!dotaz.Any())
            {
                Console.WriteLine("Databáze neobsahuje vyhledáváného pojištěnce!");
                Console.WriteLine("Přejete si hledání opakovat?[Ano/Ne]");
                string odpoved = Console.ReadLine().ToLower().Trim();
                switch (odpoved)
                {
                    case "ano":
                        VyhledejKonkretnihoPojistence();
                        break;

                    case "ne":
                        Console.WriteLine("Pokračujte libovonou klávesou...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Nerozpoznávám zadaný příkaz");
                        Console.WriteLine("Pokračujte libovonou klávesou...");
                        Console.ReadKey();
                        VyhledejKonkretnihoPojistence();
                        break;
                }
            }

        }
        //Metoda zobrazí výčet všech dat v kolekci
        public void ZobrazVsechnyPojistence()
        {
            if (pojistenci == null)
            {
                Console.WriteLine("Databáze pojištěnců je prázdná!");
                Console.ReadKey();
            }
            else
            {
                foreach (Pojistenec p in pojistenci)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("Pokračujte libovonou klávesou...");
                Console.ReadKey();
            }

        }
    }
}
