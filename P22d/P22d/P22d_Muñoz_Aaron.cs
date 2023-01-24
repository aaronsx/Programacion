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
        
        //Alumno:Muñoz Prada, Aaron Senen
        static void Main(string[] args)
        {

            bool Siono;
            int num = 0;
            int colum = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            do
            {

                Console.Clear();
                num = CapturaEntero("\n\n\t\t Elige el tamaño", 5, 100);
                int[] vNones = new int[num];
                vNones = CargaTablaNone(vNones);
                colum = CapturaEntero("En cuantas columnas las quieres?", 1, 8);
                MuestraTabla(vNones, colum);
                Siono = PreguntaSiNo("\n\n\t\tSi quieres continuar presione s para SI y si deseas salir pulse n para NO:");

            } while (!Siono);

            Salir();

        }
        static void Salir()
        {
            Console.Clear();
            Console.Write("\n\n\t\tPulsa Intro para salir");
            Console.ReadKey(true);
            
        }
        static int CapturaEntero(string txt, int min, int max)
        {

            int num = 0;
            do
            {
                Console.Write("\n {0} [{1}..{2}]:", txt, min, max);
                num = Convert.ToInt32(Console.ReadLine());
                if (num < min || num > max)
                    Console.Write("\n\n\t\tIntroduceun numero dentro de [{0}..{1}]", min, max);

            } while ((num < min || num > max));

            return num;
        }
        static int[] CargaTablaNone(int[] vNones)
        {

            int impar = 1;

            for (int i = 0; i < vNones.Length; i++)
            {
                vNones[i]= impar;
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

                Console.Write("\t {0}", vNones[i]);
            }
        }
        static bool PreguntaSiNo(string txt)
        {
            bool ok;
            
            char letra;
            do
            {

                Console.Write("{0}", txt);
                ok = Char.TryParse(Console.ReadLine() ,out letra);

                if (!ok)
                    Console.Write("\n\n\t\t***ERROR*** Introduce una letra s=Si o n=No");
                else 
                {
                    if (letra == 's' || letra == 'S')
                        return false;


                     if (letra == 'n' || letra == 'N')
                        return true;
                    
                        Console.Write("\n\n\t\t***ERROR*** Introduce una letra s=Si o n=No");


                }
                

               

            } while (true);

            



        }

    }
}
