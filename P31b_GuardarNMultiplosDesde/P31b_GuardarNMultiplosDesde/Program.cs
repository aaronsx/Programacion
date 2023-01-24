using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P31b_GuardarNMultiplosDesde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] multiplos;
            int num;
            int cantidad;
            int numDesde;
            num = CapturaEntero("Introduce un numero que quieres representar",10,99);
            cantidad = CapturaEntero("Introduce un numero desde donde quieres empezar", 10, 1000);
            numDesde = CapturaEntero("Introduce un numero como maximo", 100, 10000);
            multiplos = GuardarNMultiplosDesde(num, cantidad, numDesde);
            Console.Write("Que nombre quieres para tu fichero .TXT: ");
            StreamWriter sw = new StreamWriter(string.Format("C:\\Users\\csi22-amunada\\Desktop\\{0}.txt", Console.ReadLine()), false, Encoding.Unicode);
            for (int i = 0; i < multiplos.Length; i++)
            {
                if (i % 5 == 0 && i != 0)
                    sw.WriteLine();
                
                    sw.Write("{0}){1};", i, multiplos[i]);

                
                   
               
                
            }

            sw.Close();
        }
        static int[] GuardarNMultiplosDesde(int num, int cantidad, int numDesde)
        {
            int[] multiplos = new int[cantidad];

            int multiplo = (numDesde / num) * num;

            if (multiplo < numDesde)
                multiplo += num;

            for (int i= 0; i < multiplos.Length; i++)
            {

                multiplos[i] = multiplo;
                
                multiplo +=num;                 
            }


            return multiplos;
        }
        static int CapturaEntero(string texto, int min, int max)
        {
            int num;
            bool esCorrecto;
            do
            {
                Console.Write(" {0} [{1}..{2}]: ", texto, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out num);
                if (!esCorrecto)
                    Console.WriteLine("\n\t ** ERROR de FORMATO **");
                else if (num < min || num > max)
                {
                    Console.WriteLine(" ** ERROR: VALOR FUERA DE RANGO **");
                    esCorrecto = false;
                }
            } while (!esCorrecto);

            return num;
        }

    }
}
