using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alterberechnen
{
    class AlterBerechnen
    {
        private double _age;
        private DateTime today = DateTime.Today;

        public double Age
        {
            get
            {
                return _age;
            }

            private set
            {
                _age = value;
            }
        }
        public void calculatedays(DateTime birthdate)
        {
            TimeSpan interval = today - birthdate;
            Double days = interval.TotalDays;
            _age = Math.Round(days);
        }

        public void calculateweeks(DateTime birthdate)
        {
            TimeSpan interval = today - birthdate;
            Double weeks = interval.TotalDays / 7;
            _age = Math.Round(weeks);
        }

        public void calculatemonths(DateTime birthdate)
        {
            TimeSpan interval = today - birthdate;
            Double months = interval.TotalDays / (365.25 / 12) - 1;
            _age = Math.Round(months, 1);
        }

        public void calculateyears(DateTime birthdate)
        {
            TimeSpan interval = today - birthdate;
            Double years = interval.TotalDays / 365.25 - 1;
            _age = Math.Round(years,1);
        }
    }
}
