using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleProperties {
    public class Circle {
        private double radius;
        public double Radius {
            get { return radius; }
            set { radius = (value < 0 ? radius : value); }
        }

        public double area()
        {
            return Math.PI * radius * radius;
        }

        public double circumference()
        {
            return 2 * Math.PI * radius;
        }
    }
}
