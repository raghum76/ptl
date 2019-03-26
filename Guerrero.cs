using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jjuegoGuerra
{
    abstract class Guerrero:SerVivo 
    {
        private string _nombre;
        protected int _blanco;
        private static Random gen = new Random();
        public Guerrero(string nombre)
        {
            _nombre = nombre;
            _blanco = gen.Next(10);
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public int disparar()
        {
            if (_vivo)
                return gen.Next(10);
            else
                return -1;
        }

        public override string ToString()
        {
            return _nombre +  base.ToString();
        }
    }
}
