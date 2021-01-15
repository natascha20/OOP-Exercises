using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reise_zum_Mond
{
    class ZeitBerechnung
    {
        private int _traveltime;
        private int distance = 384400;

        public ZeitBerechnung()
        {

         }


        public int TravelTime
        {
            get
            {
                return _traveltime;
            }

            private set
            {
                _traveltime = value;
            }
        }

        public void BerechnungHouers(int speed)
        {
      
            _traveltime = distance / speed;
        }

        public void BerechnungDays(int speed)
        {
            _traveltime = distance / speed / 24;
        }
    }
}
