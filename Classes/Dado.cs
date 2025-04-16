using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogoDados.Classes
{
    class Dado
    {
        private static Random _random = new Random();
        private int _value { get; set; }

        public Dado()
        {
            _value = 0;
        }

        public int Value
        {
            get { return _value; }
        }

        public int Scroll() 
        {
            _value = _random.Next(1, 7);
            return _value;
        }
    }
}
