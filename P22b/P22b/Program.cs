using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamano = 0;
            Random random = new Random();   
            tamano = CapturaEntero("\n\n\t\tIntroduce un numero entre", 5, 100);
            int [] vEnt=new int[tamano];
            for (int i = 0; i < vEnt.Length; i++)
            {  
                vEnt[i] = random.Next( 10, 100);
               
            }
            for (int i = 0; i < vEnt.Length; i++)
                Console.Write(" {0}) {1}",i, vEnt[i]);
           int numeroABuscar= CapturaEntero("\n\n\t\tIntroduce un numero entre", 10, 100);
            bool numEncontrado;

            Salir();
        }
        static int CapturaEntero(string txt, int min, int max) 
        {
            bool ok;
            int num = 0;
            
            do
            {
                Console.Write("{0} [{1}..{2}]:", txt, min, max);
                ok = Int32.TryParse(Console.ReadLine(), out num);
                if (!ok)
                {
                    Console.WriteLine("\n\n\t\t***ERROR*** Introduce un numero");

                }
                else
                {
                    if (num < min || num > max)
                    {
                        Console.WriteLine("\n\n\t\t***ERROR*** Introduce un numero numero que este dentro de los limites");
                        ok = false;
                    }

                }
            }while(!ok);
            return num;
        }
        
        static void Salir()
        {
            Console.WriteLine("\n\n\t\tPulse cualquier tecla para salir.");
            Console.ReadLine();
        }
    }
}
