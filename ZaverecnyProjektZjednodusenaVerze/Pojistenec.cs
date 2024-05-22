using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektZjednodusenaVerze
{
    internal class Pojistenec
    {
        public string Jmeno { get; private set; }

        public string Prijmeni { get; private set; }

        public string TelCislo { get; private set; }

        public int Vek {  get; private set; }

        public Pojistenec(string jmeno, string prijmeni, int vek, string telcislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelCislo = telcislo;
            Vek = vek;
        }

        //Překrýt toString navrátí textovou podobu pojištěnce
        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni}. Věk: {Vek}, tel: {TelCislo}";
        }
    }
}
