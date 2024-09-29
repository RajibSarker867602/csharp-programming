using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    public class Circle
    {
        static float _pi = 3.1416F;
        private float _radius;
        protected Circle(float radious)
        {
            _radius = radious;
        }

        public float GetArea()
        {
            return Circle._pi * _radius;
        }

    }
}
