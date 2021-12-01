using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_7_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = MaxSTriangle(3, 4, 5, 4, 5, 6);
            Console.WriteLine(a);
            Console.ReadKey();

            double MaxSTriangle(double x1, double y1, double z1, double x2, double y2, double z2)
            {
                double p1 = (x1 + y1 + z1) / 2;
                double s1 = Math.Sqrt(p1 * (p1 - x1) * (p1 - y1) * (p1 - z1));
                double p2 = (x2 + y2 + z2) / 2;
                double s2 = Math.Sqrt(p2 * (p2 - x1) * (p2 - y1) * (p2 - z1));
                double d = s1 - s2;
                byte i = 0;
                if (d > 0)
                {
                    i = 1;
                }
                if (d < 0)
                {
                    i = 2;
                }
                if (d == 0)
                {
                    i = 0;
                }
                return i;
            }
        }
    }
}
