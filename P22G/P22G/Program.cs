using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] vFloats;
            Console.ForegroundColor= ConsoleColor.Cyan;
            int num=0;
            int column = 0;
            num = CapturaEntero("Introduce un numero entre ", 1, 100);
            vFloats=ContruyeVectorFloats(num);
            column = CapturaEntero("Numero de columnas quieres representar? ", 1, 7);
            MuestraVectorFloats(vFloats, column);
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
        static float[] ContruyeVectorFloats(int tamnyo)
        {
            float[] vFloats = new float[tamnyo];
            Random random= new Random();
           for (int i=0; i<vFloats.Length; i++) 
            {
                vFloats[i] = (float)random.Next(1000,10000)/100;
            }
           return vFloats;
        }
        static void MuestraVectorFloats(float[] vFloats,int columnas)
        {
            for(int i=0; i< vFloats.Length; i++)
            {
                if(i%columnas==0) 
                {
                    Console.WriteLine("");
                }
                Console.Write("{0}) {1}",(i+1).ToString("00"),vFloats[i].ToString("00.00"));
            }
        }
        static void Pausa(string txt)
        {
            Console.Write("\n\n\t\tPulse cualquier tecla para {0}",txt);
            Console.ReadKey(true);
        }
    }
}
