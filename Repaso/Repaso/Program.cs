using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //P22
            //    #region-----P22
            //    int num;
            //    int[] vEnt;
            //    num = CapturaEntero("Introduce un numero entero:", 5, 20);
            //    vEnt = new int[num];
            //    for (int i = 0; i < vEnt.Length; i++)
            //    {
            //        num = CapturaEntero("Introduce un numero entero:", -30, 50);
            //        if (num == 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            vEnt[i] = num;
            //        }
            //    }
            //    for (int i = 0; i < vEnt.Length; i++)
            //    {
            //        Console.WriteLine(i + ") " + vEnt[i]);
            //    }
            //}
            //#endregion

            //p22Float
            //#region--p22float
            //float[] vFloat;
            //int columnas;
            //int num = CapturaEntero("Introduce un numero:", 1, 100);
            //vFloat = ConstruyeVectorFloats(num);
            //columnas= CapturaEntero("Introduce un numero:", 1, 7);
            //MuestraVectorFloats(vFloat,columnas);
            //#endregion

            //P220
            //#region---Apellidos
            //string [] vApellidos = {"Sánchez Elegante", "Arenas Mata", "García Solís",
            //                     "Delgado Rodríguez", "Hurtado Miranda", "Pinto Mirinda", "Barrios Garrobo", "Márquez Salazar", "Medina Gómez", "Alonso Pérez",
            //                     "Delgado Rodríguez", "González Chaparro", "Ferrer Jiménez", "Morales Moncayo", "Fernández Perea", "Blanco Roldán", "Navarro Romero",
            //                     "Delgado Rodríguez", "Baena Fernández", "Barco Ramírez", "Delgado Rodríguez", "Duque Martínez"};
            //string [] vNombres = {"Álvaro", "Daniel Luis", "Juan Manuel", "Agustín", "Fco. Javier", "José Manuel", "Tomás", "Carlos", "Jose Carlos", "Juan Luis",
            //                    "Delgado Rodríguez", "Angel", "Jacobo", "Alejandro", "Francisco", "Alfredo",
            //                   "Delgado Rodríguez", "Antonio", "Constantino", "Roberto", "Rafael", "Antonio"};
            //string[,] tab2dGente=new string[vNombres.Length,2];
            //string [] vApellNomb=new string[vNombres.Length];
            //for (int i= 0; i<vApellidos.Length;i++) 
            //{
            //    tab2dGente[i, 0] = vApellidos[i];
            //    tab2dGente[i, 1] = vNombres[i];

            //}
            //for (int i=0;i < vApellidos.Length; i++) 
            //{
            //    if (i < 10)
            //        Console.WriteLine("");

            //    Console.WriteLine("\t{0}) {1} {2}", (i + 1), tab2dGente[i, 1], tab2dGente[i, 0]);
            //}

            //for (int i = 0; i < vApellidos.Length; i++)
            //{

            //    vApellNomb[i] = ( vApellidos[i]+","+vNombres[i]);
            //}
            //tabApellNomb(vApellNomb);
            //int maxLong = 0;
            //string personaMaxLong = "";
            //for (int i = 0; i < vApellidos.Length; i++)
            //{
            //    if (vApellNomb[i].Length > maxLong)
            //    {
            //        personaMaxLong = vApellNomb[i];
            //        maxLong = personaMaxLong.Length;
            //    }
            //}

            //    #endregion


            //p22g

            //#region----Numeros random

            //ColocaNúms0a99Azar();
            //int num;
            //do
            //{
            //    Console.SetCursorPosition(10, 24);
            //    num = CapturaEntero("Dime el número a colocar: ", 0, 99);
            //    Console.BackgroundColor = ConsoleColor.Red;
            //    Console.ForegroundColor = ConsoleColor.White;
            //    ColocaNúms0a99Azar();
            //    Console.ResetColor();

            //} while (num != 0);

            //Console.Write("\n\n\n\tPulsa tecla para salir");
            //Console.ReadKey();
            //#endregion


           









            Console.WriteLine("Pulsa para salir");
            Console.ReadKey(true);
        }
        static void ColocaNúms0a99Azar()
        {
            int num;
            Random random = new Random();
            for (int i = 0; i <= 200; i++)
            {
                num = random.Next(0, 100);
                ColocaElNumero(num);

            }

        }


        static void ColocaElNumero(int num)
        {
            int columna = 10 + 5 * (num % 10);
            int fila = 1 + 2 * (num / 10);
            Console.SetCursorPosition(columna, fila);
            Console.Write(num.ToString("00"));
        }
        static void MuestraNums0a99()
        {



            for (int num = 10; num < 100; num++)
            {

                ColocaElNumero(num);
            }
        }
        //static void MuestraNums0a99()
        //{

        //    for (int num = 0; num < 10; num++)
        //        Console.Write("    {0}  ", num);

        //    for (int num = 10; num < 100; num++)
        //    {

        //        if (num % 10 == 0)
        //            Console.WriteLine("\n");
        //        Console.Write("   {0}  ", num);
        //    }
        //}
        private static void tabApellNomb(string[] vApellNomb)
        {
            for (int i = 0; i < vApellNomb.Length; i++)
            {
                if (i < 10)
                    Console.WriteLine("");

                Console.WriteLine("\t{0}) {1} {2}", (i + 1), vApellNomb[i]);
            }
        }

        static void MuestraVectorFloats(float[] vFloat, int columnas)
        {

            for (int i = 0; i < vFloat.Length; i++)
            {
                if (i % columnas == 0)
                    Console.WriteLine();
                if (i < 10)
                    Console.Write(" ");

                Console.Write("{0})  {1}", i, vFloat[i].ToString("00.00"));
            }
        }
        static float[] ConstruyeVectorFloats(int tamanyo)
        {
            Random random = new Random();

            float[] vFloat = new float[tamanyo];
            for (int i = 0; i < vFloat.Length; i++)
            {
                vFloat[i] = (float)random.Next(1000, 10000) / 100;

            }

            return vFloat;
        }
        static int CapturaEntero(string txt, int min, int max)
        {
            bool ok;
            int num;
            do
            {
                Console.Write("{0} [{1}...{2}]", txt, min, max);
                ok = Int32.TryParse(Console.ReadLine(), out num);
                if (!ok)
                {
                    Console.Write("***ERROR*** Introduce uun numero valido");
                }
                else
                {
                    if (num < min || num > max)
                    {
                        Console.Write("***ERROR*** Numero fuera de rango");
                        ok = false;
                    }
                }
            } while (!ok);
            return num;
        }

    }
}
