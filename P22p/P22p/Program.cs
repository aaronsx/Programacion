using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
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
        static void ColocaElNumero(int num)
        {
            int columna = 10 + 5 * (num % 10);
            int fila = 1 + 2 * (num / 10);
            Console.SetCursorPosition(columna, fila);
            Console.WriteLine(num.ToString("00"));
            

        }
        static void CargaTabla()
        {
            Random random = new Random();
            

            for (double i = 10; i < 100; i++)
            {
                ColocaElNumero(random.NextDouble(1.3));
            }
            
        }
        static void Pausa(string txt)

        {
            Console.SetCursorPosition(10, 24);
            Console.Write("\n\n\t\tPulse cualquier tecla para {0}", txt);
            Console.ReadKey(true);
            if (txt == "para reanudar")
                Console.Clear();
        }
    }
}
