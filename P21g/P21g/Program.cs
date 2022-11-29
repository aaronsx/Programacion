using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace P21g
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
           
            for (int i = 0;i<100;i++) 
            {
                Console.SetCursorPosition(10,1);
                if (i % 5 == 0)
                    Console.SetCursorPosition(5, 10);

                Console.Write(i);
            }

            Pausa("salir");
        }
        static void Pausa(string txt)
        {
            Console.Write("\n\n\t\tPulse cualquier tecla para {0}", txt);
            Console.ReadKey(true);
        }
    }
    
    
}
