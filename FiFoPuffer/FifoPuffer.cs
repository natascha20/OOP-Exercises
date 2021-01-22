using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiFoPuffer
{
    class FifoPuffer
    {
        int[] _puffer;
        int _courser;
        int _groesse;

        public FifoPuffer(int groesse)
        {
            _groesse = groesse;
            _puffer = new int[_groesse];
            _courser = -1;
        }

        public void Put(int zahl)
        {
            _puffer[++_courser] = zahl;
        }

        public int Get()
        {
            if(_courser == -1)
                throw new Exception("Der Puffer ist Leer");

            return GetFirst();
        }

        public string GetAll()
        {
            if (_courser == -1)
                throw new Exception("Der Puffer ist Leer");

            StringBuilder resultat = new StringBuilder();

            for(int i = 0; i <= _courser; i++)
            {
                resultat.Append(_puffer[i]);
                if(i < _courser)
                {
                    resultat.Append(",");
                }
            }

            return resultat.ToString();
        }

        public int GetFirst()
        {
            int[] _tmpc = new int[_groesse];
            _puffer.CopyTo(_tmpc,0);

            for(int i = 0; i < _courser; i++)
            {
                _puffer[i] = _tmpc[i];
            }


            return _tmpc[0];
        }

    }
}
