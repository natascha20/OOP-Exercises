using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaumzeichnen
{
    class Tanne
    {
        string _resultat = string.Empty;
        int stammbreite;
        int stammhoehe;
        int kronenhoehe;

        public int Stammbreite
        {
            get
            {
                return stammbreite;
            }

            set
            {
                stammbreite = value;
            }

        }

        public int Stammhoehe
        {
            get
            {
                return stammhoehe;
            }

            set
            {
                stammhoehe = value;
            }
        }

        public int Kronenhoehe
        {
            get
            {
                return kronenhoehe;
            }
            
            set
            {
                kronenhoehe = value;
            }
        }

        public string Resultat
        {
            get
            {
                return _resultat;
            }
        }

        public Tanne()
        {

        }

        public Tanne(int kronenHoehe, int stammBreite, int stammHoehe)
        {
            this.Kronenhoehe = kronenHoehe;
            this.Stammbreite = stammBreite;
            this.Stammhoehe = stammHoehe;
        }

        public void Zeichne()
        {
            ZeichneKrone();
            ZeichneStamm();
        }

        public void ZeichneKrone()
        {
            for(int i = 0; i <= Kronenhoehe; ++i)
            {
                ZeichneZeile(Kronenhoehe - i, 2 * i - 1);
            }
                
        }

        private void ZeichneZeile(int anfang, int breite)
        {
            int i;

            for(i = 1; i <= anfang; ++i)
            {
                _resultat += " ";
            }

            for(i = 1; i <= breite; ++i)
            {
                _resultat += "*";
            }

            _resultat += Environment.NewLine;
        }

        public void ZeichneStamm()
        {
            for(int i = 1; i <= Stammhoehe; ++i)
            {
                ZeichneZeile(Kronenhoehe - Stammbreite / 2 - 1, Stammbreite);
            }
        }
    }
}
