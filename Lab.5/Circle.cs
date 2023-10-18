using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._5
{
    public class Circle
    {
     
            public  void GetArea()
            {
                Console.WriteLine("Skriv in radie i cm till en cirkel så visar jag dess area");
                double radius = Convert.ToInt32(Console.ReadLine());

                double area = radius * radius * Math.PI;
                Console.WriteLine(area);

            }
        }
    }

