using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace P21c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int min = 0;
            int max = 0;
            int resultado;
            int contador = 0;
            int columnas;
         
        
                
                min = CapturaEntero("\t\n\nIntroduce un minimo:", min);
                max = CapturaEntero("\t\n\nIntroduce un maximo:", max);
                resultado = CapturaEntero(min, max);
                columnas = CapturaEntero("\t\n\nPulse intro si desea que se muestre en columnas", min, max, 6);
 

            


            Console.Write("\n\n\t\tPulsa Intro para salir");
            Console.ReadLine();
        }
        static int CapturaEntero(string txt, int min) 
        {
            bool minok;
           
            do
            {
                
                Console.Write("{0}", txt);
                minok = Int32.TryParse(Console.ReadLine(), out min);
                
                if (!minok)
                {
                    Console.WriteLine("\t\n\n***Error** Introduce un numero.");

                }
                else if (min < 100 || min>999)
                {
                    Console.WriteLine("\t\n\n***Error** Introduce un valor adecuado.");
                    minok = false;
                }
            } while (!minok);
            return min;
            
        }

        static int CapturaEntero(int min, int max)
        {
            int contador = 0;
            if (min >= max )
            {
                while (min >= max)
                {
                    Console.WriteLine("\t\n\n***Error** Introduce un valor adecuado.");
                    min = CapturaEntero("\t\n\nIntroduce un minimo:", min);
                    max = CapturaEntero("\t\n\nIntroduce un maximo:", max);

                }
            }
            else 
            { 
                do
                {
                    min++;
                    if (!(min % 2 == 0))
                    {

                        Console.Write(" " + min);
                        contador++;
                    }
                
                } while (min < max);
            }
            return min;
        }
        static int CapturaEntero(string txt, int min, int max, int nc)
        {
            int contador = 0;
            Console.Write("{0}", txt);
            Console.ReadLine();

            do
            {
                min++;
                if (!(min % 2 == 0))
                {
                    if (contador++ % nc == 0)
                    {
                        Console.WriteLine(" ");
                    }
                    Console.Write(" " + min);
                    
                }

            } while (min < max);
            
            return min;
        }
    }
}
