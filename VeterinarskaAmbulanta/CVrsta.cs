using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaAmbulanta
{
    internal class CVrsta
    {
        private static List<CVrsta> Vrste = new List<CVrsta>();
        private static int Index_ID;
        private int ID;
        private string Naziv;

        private CVrsta(int ID, string Naziv)
        {
            this.ID = ID;
            this.Naziv = Naziv;
        }
        public static void setIndexID(int ID)
        {
            Index_ID = ID;
        }

        public static void obrisiVrste()
        {
            CVrsta.Vrste.Clear();
        }
        public static void dodajVrstu(int ID, string Naziv)
        {
            CVrsta.Vrste.Add(new CVrsta(ID, Naziv));
        }

        public static void dodajNovuVrstu(string Naziv)
        {
            CVrsta.Vrste.Add(new CVrsta(Index_ID, Naziv));
        }

        public static List<CVrsta> vratiVrste()
        {
            return Vrste;
        }

        public int vratiID()
        {
            return this.ID;
        }

        public override string ToString()
        {
            return this.Naziv;
        }
    }
}
