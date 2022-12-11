using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaAmbulanta
{
    internal class COsoba
    {
        private static List<COsoba> Osobe = new List<COsoba>();
        private List<CLjubimac> Ljubimci = new List<CLjubimac>();
        private static int Index_ID;
        private int ID;
        private string Ime, Prezime;
        private char[] OIB = new char[11];

        private COsoba(int ID, string Ime, string Prezime, char[] OIB)
        {
            this.ID = ID;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.OIB = OIB;
        }

        public static void setIndexID(int ID)
        {
            Index_ID = ID;
        }

        public static void obrisiOsobe()
        {
            COsoba.Osobe.Clear();
        }

        public static void dodajOsobu(int ID, string Ime, string Prezime, char[] OIB)
        {
            COsoba.Osobe.Add(new COsoba(ID, Ime, Prezime, OIB));
        }

        public static void dodajNovuOsobu(string Ime, string Prezime, char[] OIB)
        {
            COsoba.Osobe.Add(new COsoba(Index_ID, Ime, Prezime, OIB));
        }

        public void dodajLjubimca(CLjubimac ljubimac)
        {
            this.Ljubimci.Add(ljubimac);
        }

        public void obrisiLjubimce()
        {
            this.Ljubimci.Clear();
        }

        public List<CLjubimac> vratiLjubimce()
        {
            return this.Ljubimci;
        }

        public static List<COsoba> vratiOsobe()
        {
            return Osobe;
        }

        public int vratiID()
        {
            return this.ID;
        }

        public override string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}
