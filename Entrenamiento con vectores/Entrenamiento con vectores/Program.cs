using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrenamiento_con_vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            //Ejercicio 0
            int[] tabla1 = new int[24];
            Random random= new Random();
            for(int i=0; i<tabla1.Length; i++)
            {
                tabla1[i] = random.Next(1, 1001);
                Console.Write("\t{0}", tabla1[i]);
            }
            //Ejercicio 1
            int num;
            int[] tabla2 = new int[num];




            Console.Write("\n\n\t\tPulsa Intro para salir");
            Console.ReadLine();
        }
        static int CapturaEntero()
        {
            int num;
            Console.Write("\n\n\t\tIntroduce el numero");
            return num;
        }
    }
}
