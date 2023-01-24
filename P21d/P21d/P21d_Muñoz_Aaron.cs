using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21d
{
    //Alumno: Muñoz Prada, Aaron Senen
    internal class P21d_Muñoz_Aaron
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int num=0;
            int tope = 0;
            int suma = 0;
            num = CapturaEntero(num);
            tope= CapturaEntero("\t\n\nIntroduce un segundo numero:", num);
            
            Console.Write("La suma total es: "+(suma =MultiplosMenoresDe(num, tope)));



            Console.Write("\n\n\t\tPulsa Intro para salir");
            Console.ReadLine();
        }
        static int CapturaEntero(int num)
        {
            bool minok;

            do
            {

                Console.Write("\t\n\nIntroduce un primer numero:");
                minok = Int32.TryParse(Console.ReadLine(), out num);

                if (!(minok))
                {
                    Console.WriteLine("\t\n\n***Error** Introduce un numero.");

                }
                else if (num < 10 || num > 98)
                {
                    Console.WriteLine("\t\n\n***Error** Introduce un numero mayor que 10 y menor que 99.");
                    minok = false;
                }
            } while (!(minok));
            return num;
        }
        static int CapturaEntero(string txt, int nume)
        {
            int num;
            bool numok;
            do
            {
                numok = true;
                Console.Write("{0} ", txt);
                numok = Int32.TryParse(Console.ReadLine(), out num);
                if (!numok)
                {
                    Console.WriteLine("\n\t\t** Error: No ha introducido un valor correcto**");
                }
                else if (num < 1 || num <= nume)
                {
                    Console.WriteLine("\n\t\t** Error:Introduce un valor positivo");

                    numok = false;
                }
                

            } while (!numok);

            return num;

        }
        static int MultiplosMenoresDe(int num, int limiteSup)
        {
           int suma = 0;
            for (int i = num; i <= limiteSup; i++ )
            {
                if (i % num == 0)
                {
                    Console.WriteLine(i);
                    suma += i;
                }   
            }
            return suma;
        }

        
       
    
    }
}
