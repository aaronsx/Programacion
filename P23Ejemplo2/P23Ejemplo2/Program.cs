using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list;
            int num = 0;
            num = CapturaEntero("Cuantos elementos deseas cargar", 10, 24);
            list = new List<char>(num);

            Pausa("salir");
        }
        static void MuestraListaEnColumna(List<char> lista)
        {
            
        }
        
        
        static int CapturaEntero(string texto, int min, int max)
        {
            bool esCorrecto;
            int valor;
            do
            {
                Console.Write("{0} [{1}..{2}]: ", texto, min, max);

                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto)
                    Console.WriteLine("\n\n\t** Error: el valor introducido no es un número entero");
                else if (valor < min || valor > max)
                {
                    esCorrecto = false;
                    Console.WriteLine("\n\n\t** Error: el valor introducido no está dentro del rango");
                }
            } while (!esCorrecto);
            return valor;
        }
        static void Pausa(string txt)
        {
            Console.Write("\n\n\t\tPulse cualquier tecla para {0}", txt);
            Console.ReadKey(true);
        }
    }
}
