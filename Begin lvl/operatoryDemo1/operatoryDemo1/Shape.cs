using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoryDemo1
{
    class Shape
    {
        public int a;
        public bool b;

        public Shape()
        {
        }

        public Shape(int a)
        {
            this.a = a;
        }

        public static Shape operator +(Shape shape1, Shape shape2)
        {
            Shape sum = new Shape();
            sum.a = shape1.a + shape2.a;

            return sum;
        }

        public static Shape operator ==(Shape shape1, Shape shape2)
        {
            Shape shape = new Shape();
            if (shape1.a == shape2.a) shape.b = true;
            else shape.b = false;

            return shape;
        }

        public static Shape operator !=(Shape shape1, Shape shape2)
        {
            return null;
        }
            
    }
}
