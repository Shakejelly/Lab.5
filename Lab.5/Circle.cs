using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._5
{
    public class Circle
    {
        public double Radius {  get; set; }
        
        public Circle(double radius)
        {
            Radius = radius;
           
        }
        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}

