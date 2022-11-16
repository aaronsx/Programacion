using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21e
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int opcion, num = 0;
            do
            {
                opcion = Menu();
                num = CapturaEntero("\n\tIntroduzca un número de dos cifras: ", opcion);
                switch (opcion)
                {
                    case 1:
                         MultiplosMenoresDe(num, 300);
                        break;
                    case 2:
                        PrimerosMultiplos(num, 100);
                        break;
                    case 3:
                        MultiplosEntre(num, 500, 700);
                        break;
                    case 4:
                        MultiplosDesde(num, 80, 700);
                        break;
                }
                if (opcion != 0)
                {
                    Console.WriteLine("\n\nPulse una tecla para Volver al menú");
                    Console.ReadKey();
                }
            } while (opcion != 0);
            Console.Write("\n\n\tPulsa una tecla para salir");
            Console.ReadKey();

        }
        static int Menu()
        {
            int opcion;

                Console.Clear();
                Console.WriteLine("\n\n\t\t╔════════════════════════════════════╗");
                Console.WriteLine("\t\t║           Menú Múltiplos           ║");
                Console.WriteLine("\t\t╠════════════════════════════════════╣");
                Console.WriteLine("\t\t║                                    ║");
                Console.WriteLine("\t\t║   1) Múltiplos menores 300         ║");
                Console.WriteLine("\t\t║                                    ║");
                Console.WriteLine("\t\t║   2) Cien Primeros Múltiplos       ║");
                Console.WriteLine("\t\t║                                    ║");
                Console.WriteLine("\t\t║   3) Múltiplos Entre 500 y 700     ║");
                Console.WriteLine("\t\t║                                    ║");
                Console.WriteLine("\t\t║   4) Ochenta Múltiplos Desde 700   ║");
                Console.WriteLine("\t\t║____________________________________║");
                Console.WriteLine("\t\t║                                    ║");
                Console.WriteLine("\t\t║           0) Salir                 ║");
                Console.WriteLine("\t\t╚════════════════════════════════════╝");

                Console.Write("\t\tIntroduce una opción: ");
                opcion = Console.ReadKey().KeyChar - '0';


                while (opcion < 0 || opcion > 4)
                {
                    Console.WriteLine("\n\t\t\t*ERROR*");
                    Console.Write("\t\tIntroduce una opción: ");
                    opcion = Console.ReadKey().KeyChar - '0';
                }
            Console.Clear();


            return opcion;
           
        }
        static int CapturaEntero(string txt, int opcion)
        {
            int num = 0;
            if (opcion != 0)
            {
                do
                {
                    Console.Write("{0}",txt);
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num < 10 || num > 99)
                        Console.Write("\n\t** Error!! número fuera de rango **\n");
                } while (num < 10 || num > 99);
            }
            return num;
        }
        static void MultiplosMenoresDe(int num, int lim)
        {
            

            Console.WriteLine("\n\t----- Múltiplos de {0} menores de {1} -----", num, lim);
            Console.WriteLine("\t------------------------------------------\n");
            int multiplo = num;
            while (multiplo < lim)
            {
                Console.Write("\t" + multiplo);

                multiplo += num;
            }
            
        }
        static void PrimerosMultiplos(int num, int lim)
        {

           

            Console.WriteLine("\n\t----- {0} primeros múltiplos de {1} -----", lim, num);
            Console.WriteLine("\t----------------------------------------\n");

            for (int i = 1; i <= lim; i++)
                Console.Write("\t{0}", i * num);

        }
        static void MultiplosEntre(int num, int min, int lim)
        {
           

            Console.WriteLine("\n\t----- Múltiplos de {0} entre {1} y {2} -----", num, min, lim);
            Console.WriteLine("\t-------------------------------------------\n");

            int multiplo = (min / num) * num;

            if (multiplo < min)
                multiplo += num;


            while (multiplo <= lim)
            {
                Console.Write("\t{0}", multiplo);
                multiplo += num;
            }

        }
        static void MultiplosDesde(int num, int cant, int min)
        {
            

            Console.WriteLine("\n\t----- {0} primeros múltiplos de {1} a partir de {2} -----", cant, num, min);
            Console.WriteLine("\t-------------------------------------------------------\n");



            int multiplo = (min / num) * num;

            if (multiplo < min)
                multiplo += num;


            for (int i = 0; i < cant; i++)
            {
                Console.Write("\t" + multiplo);
                multiplo += num;
            }

        }
       
        
    }
}






