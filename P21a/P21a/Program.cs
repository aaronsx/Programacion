using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant, min, num, nc;
            bool esCorrecto;

            cant = CapturaEntero2("\n\tCantidad de múltiplos a presentar? ", 100, 300);
            min = CapturaEntero2("\n\t¿Número del que obtener sus múltiplos? ", 11, 77);
            num = CapturaEntero2("\n\t¿Valor mínimo? ", 1000, 2000);
          
            int multiplo = (min / num) * num;
            if (multiplo < min)
                multiplo += num;
            for (int i = 0; i < cant; i++)
            {

                if (i % nc == 0)
                    Console.WriteLine();

                Console.Write("{0}\t", multiplo);
                multiplo += num;
            }

            Console.Clear();
            Console.WriteLine("\n{0} primeros múltiplos de {1} a partir de {2} en {3} columnas", cant, num, min, nc);

            Console.Write("\n\n\tPulsa una tecla para salir");
            Console.ReadKey();
        }

        //static int CapturaEntero(string txt, int min, int max)
        //{
        //    bool ok;
        //    int valor = 0;


        //    do
        //    {
        //        Console.Write("{0} [{1}...{2}]", txt, min, max);
        //        ok = Int32.TryParse(Console.ReadLine(), out valor);

        //        if (!ok)
        //            Console.WriteLine("\n** Error: Valor introducido no válido **");
        //        else if (valor < min || valor > max)
        //        {
        //            Console.WriteLine("\n** Error: El número no está en el rango pedido **");
        //            ok = false;
        //        }

        //    } while (!ok);
        //    return valor;
        //}
        static int CapturaEntero2(string txt, int min, int max)
        {
            bool ok ;
            int valor ;

            Console.Write("{0} [{1}...{2}]", txt, min, max);
            ok = Int32.TryParse(Console.ReadLine(), out valor);
          

            while (!ok || valor < min || valor > max)
            {
                if (!ok)
                    Console.WriteLine("\n** Error: Valor introducido no válido **");
                else 
                {
                    Console.WriteLine("\n** Error: El número no está en el rango pedido **");
                }
                Console.Write("{0} [{1}...{2}]", txt, min, max);
                ok = Int32.TryParse(Console.ReadLine(), out valor);
                 
            }

            return valor;
        }
    }
}
