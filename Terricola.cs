using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jjuegoGuerra
{
    class Terricola : Guerrero
    {
        private static int _cuantosVivos = 0;
        public Terricola(string nombre): base(nombre)
        {
            _cuantosVivos++;
        }

        public int CuantosVivos
        {
            get { return _cuantosVivos; }
        }

        public void recibirDisparo(int tiro)
        {
            if (_vivo && _blanco == tiro)
            {
                _vivo = false;
                _cuantosVivos--;
            }
        }
    }
}
