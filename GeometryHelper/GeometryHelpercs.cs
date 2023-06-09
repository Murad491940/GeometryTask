using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryHelper
{
    static class GeometryHelpercs
    {
        public static void SquareArae(int a)
        {
            Console.WriteLine ("Kvadratin sahesi: "+a * a);
        }
        public static void TriangeArae(int a, int b,int c)
        {
            Console.WriteLine("Ucbucaqin perimetri: "+(a + b + c)/2);
        }
        
    }
}
