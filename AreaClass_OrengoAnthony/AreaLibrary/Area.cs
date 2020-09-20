using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Area
    {
        //Calculate rectangle area using formula and return answer.
        public static double CalculateArea(int length, int width)
        {           
            return length * width;
        }
        //Calculate circle area using formula and return answer rounded to two decimal places.
        public static double  CalculateArea(double radius)
        {
           return Math.Round(Math.PI * (radius * radius), 2);
        }
        //Calculate cylinder area using formula and return answer rounded to two decimal places.
        public static double CalculateArea(double radius, double h)
        {            
            return Math.Round(2 * Math.PI * radius * radius + h * (2 * Math.PI * radius), 2);
        }
    }
}
