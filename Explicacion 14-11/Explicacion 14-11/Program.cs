using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicacion_14_11
{
    
    internal class Program
    {
        int x = 3;
        int y = 4;
        static void Main(string[] args)
        {
            double m = MediaDe2();
            Print("\n\n\tLa media de las dos vale" + m.ToString());
            Console.WriteLine("\t\n\nPulsa intro para salir");
            Console.ReadKey();
        }
        static void Print(string s) 
        { 
            Console.WriteLine(s);
        }
        static double MediaDe2()
        {
            
            double media = (x + y) / 2.0;
            return media;
        }
    }
}
