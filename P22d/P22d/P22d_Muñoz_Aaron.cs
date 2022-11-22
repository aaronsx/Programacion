using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22d
{
    internal class Program
    {
        static int[] vNones;
        static void Main(string[] args)
        {
            int num = 0;
            int colum = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Cuantos impares quieres cargar? [5..100]");
            num = Convert.ToInt32(Console.ReadLine());
            vNones=CargaTablaNone(num);
            Console.Write("En cuantas columnas las quieres? [1..8]");
            colum=Convert.ToInt32(Console.ReadLine());
            MuestraTabla(vNones, colum);





            Console.Write("\n\n\t\tPulsa Intro para salir");
            Console.ReadLine();
        }
        static int[] CargaTablaNone(int numE)
        {
            int impar = 1;
            Random random = new Random();
            vNones =new int[numE];
            for(int i=0; i< vNones.Length; i++) 
            {
                vNones[i] = impar;
                impar += 2;
            }
            return vNones;

        }
        static void MuestraTabla(int[] vNones, int colum)
        {
            int cont = 0;
            for (int i = 0; i < vNones.Length; i++)
            {
                if (cont++ % colum == 0)
                    Console.WriteLine(" ");

                Console.Write(vNones[i]);
            }
        }
    }
}
