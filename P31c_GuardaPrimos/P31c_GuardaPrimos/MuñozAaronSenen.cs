using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31c_GuardaPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Cyan;
            List<int> ListaPrimos = new List<int>();
            int top;
            top = CapturaEntero("Introduce un numero maximo que este entre", 10, 10000);
            ListaPrimos=ListaDePrimos(top);
            StreamWriter sw = new StreamWriter("C:\\zDatosPrueba\\primos.txt",  false, Encoding.Unicode);
            for (int i = 0; i < ListaPrimos.Count(); i++)
            {
                if (i % 5 == 0 && i != 0)
                    sw.WriteLine();

                sw.Write("{1}; ", i, ListaPrimos[i]);
            }
            sw.Close();
        }
        static bool EsPrimo(int num)
        {
            
            if (num == 0 || num == 1 || num == 4)
                return false;
            
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            
            return true;
        }
        static List<int> ListaDePrimos(int limiteSup)
        {
            List<int> ListaPrimos= new List<int>();
            int num=0;
            for (int i=0; i < limiteSup;i++)
            {
                
                if (EsPrimo(num))
                {
                    ListaPrimos.Add(num);
                }
                num++;
            }
            return ListaPrimos;
        }
        static int CapturaEntero(string txt, int min, int max)
        {
            int valor;
            bool esCorrecto;

            Console.Write("{0} [{1}..{2}]: ", txt, min, max);
            esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
            while (!esCorrecto || valor < min || valor > max)
            {
                
                if (!esCorrecto)
                    Console.WriteLine("\n** Error: Valor introducido no es un número entero **");

                else
                    Console.WriteLine("\n** Error: El número no está en el rango pedido **");

                Console.Write("{0} [{1}..{2}]: ", txt, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        }
    }
}
