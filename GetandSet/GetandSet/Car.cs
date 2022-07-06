using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetandSet
{
    class Car
    {
        private int _speed;

        public int Speed
        {
            get => _speed;
            set => _speed = value > 500 ? 500 : value;
        }
    }
}
