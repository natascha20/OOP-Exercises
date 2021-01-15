using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteckberechnen
{
    public class Rechtecksberechnung
    {
        private int _rechtecksflaeche;

        public int Rechtecksflaeche
        {
            get
            {
                return _rechtecksflaeche;
            }

            private set
            {
                _rechtecksflaeche = value;
            }

          
        }

        public void Berechnung(int rechteckshoehe, int rechtecksbreite)
        {
            if (rechteckshoehe <= 0 || rechtecksbreite <=0)
            {
                throw new Exception("Keine gültige Längen Angabe");
            }
            else
            {
                _rechtecksflaeche = rechteckshoehe * rechtecksbreite;
            }
          
        }
    }
}


    

    

