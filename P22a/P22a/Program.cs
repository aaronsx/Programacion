using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P22a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            num = CapturaEntero("\n\n\n\t\t\t\tIntroduce el tamaño de la tabla [{0}..{1}]", 5, 20);
            Console.Write("\n\n\n\t\t\t\tPulsa una tecla para salir");
            Console.ReadKey();




            else
            {
                int[] vEnt = new int[num];
                int i = 0;
                while (i < vEnt.Length)
                {

                    Console.Write("\n\t\tIntroduce un numero en la posicion " + i + "con tamaño [-30...50]:");
                    vEnt[i] = Convert.ToInt32(Console.ReadLine());

                    if (vEnt[i] == 0)
                        break;

                    i++;
                }
                for (int a = 0; a < vEnt.Length; a++)
                {
                    Console.Write("\t {0}", vEnt[a]);
                }
            }

        }
        static int CapturaEntero(string txt, int min, int lim)
        {


            bool ok = true;
            int num = 0;
            do
            {
                Console.Clear();
                Console.Write("{0}", txt);
                ok = Int32.TryParse(Console.ReadLine(), out num);

                if (!ok)
                    Console.Write("\n\n\n\t\t\t\t***ERROR*** Introduce un numero");

                else
                {
                    if (num < min || num > lim)
                    {
                        Console.Write("\n\n\n\t\t\t\tERROR numero fuera de rango.");
                        ok= false;
                       
                    }       
                }

            } while (!ok);
            return num;
        }
    }
}
