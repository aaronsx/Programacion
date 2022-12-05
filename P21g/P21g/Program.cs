using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            int num;
            MuestraNums099();
            Pausa("para reanudar");
            ColocaNums0a99();
            Pausa("para reanudar");
            ColocaNúms0a99Azar();
            
            do
            {
                Console.SetCursorPosition(10, 24);
                num = CapturaEntero("Dime un numero para colocar entre", 0, 99);
                Console.BackgroundColor= ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                ColocaElNumero(num);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                
            } while (num != 0);
            Pausa("salir");
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
        static void MuestraNums099()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                    Console.WriteLine("\n");

                Console.Write("   {0}  ", i.ToString("00"));
            }

        }
        static void ColocaNums0a99()
        {
            
            for (int i = 0; i < 100; i++)
                ColocaElNumero(i);
        }
        static void ColocaNúms0a99Azar()
        {
            //bool[] vExiste = new bool[100];
            //Random random = new Random();
            //int num;
            //for (int i = 0; i < 100; i++)
            //{
            //    num = random.Next(100);
            //    do
            //    {
            //        if (!vExiste[num])
            //            ColocaElNumero(num);


            //    }while(vExiste[num]);
            //    vExiste[num] = true;
            //}
            Random random = new Random();
           
            for (int i = 0; i < 100; i++)
            {
                ColocaElNumero(random.Next(100));                 
            }
        }
        static void ColocaElNumero(int num) 
        {
            int columna = 10 + 5 * (num%10) ;
            int fila = 1 + 2 * (num/10) ;
            Console.SetCursorPosition(columna, fila);
            Console.WriteLine(num.ToString("00"));
            Console.Beep(200 + 40 * num, 100);
            
        }
        static void Pausa(string txt)

        {
            Console.SetCursorPosition(10,24);
            Console.Write("\n\n\t\tPulse cualquier tecla para {0}", txt);
            Console.ReadKey(true);
            if (txt == "para reanudar")
                Console.Clear();
        }
    }
    
    
}
