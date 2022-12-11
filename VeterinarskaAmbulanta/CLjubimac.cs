using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaAmbulanta
{
    internal class CLjubimac
    {
        private static List<CLjubimac> Ljubimci = new List<CLjubimac>();
        private static int Index_ID;
        private int ID, GodinaProizvodnje;
        private string Naziv;
        private CVrsta Vrsta;
        private bool Uginuo;

        private CLjubimac(int ID, string Naziv, CVrsta Vrsta, int GodinaProizvodnje, bool Uginuo)
        {
            this.ID = ID;
            this.Naziv = Naziv;
            this.Vrsta = Vrsta;
            this.GodinaProizvodnje = GodinaProizvodnje;
            this.Uginuo = Uginuo;
        }

        public static void setIndexID(int ID)
        {
            Index_ID = ID;
        }
        public static int getIndexID()
        {
            return Index_ID;
        }

        public static void obrisiLjubimce()
        {
            CLjubimac.Ljubimci.Clear();
        }

        public static void dodajLjubimca(int ID, string Naziv, CVrsta Vrsta, int GodinaProizvodnje, bool Uginuo)
        {
            CLjubimac.Ljubimci.Add(new CLjubimac(ID, Naziv, Vrsta, GodinaProizvodnje, Uginuo));
        }
        
        public static void dodajNovogLjubimca(string Naziv, CVrsta Vrsta, int GodinaProizvodnje, bool Uginuo)
        {
            CLjubimac.Ljubimci.Add(new CLjubimac(Index_ID, Naziv, Vrsta, GodinaProizvodnje, Uginuo));
        }

        public static List<CLjubimac> vratiLjubimce()
        {
            return Ljubimci;
        }

        public bool Ziv()
        {
            return !this.Uginuo;
        }

        public int vratiID()
        {
            return this.ID;
        }
        public string vratiNaziv()
        {
            return this.Naziv;
        }

        public CVrsta vratiVrstu()
        {
            return this.Vrsta;
        }

        public int vratiGodinuProizvodnje()
        {
            return this.GodinaProizvodnje;
        }
        public bool vratiUginuo()
        {
            return this.Uginuo;
        }

        public override string ToString()
        {
            return this.Vrsta + " " + this.Naziv;
        }
    }
}
