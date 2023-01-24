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
            Console.ForegroundColor = ConsoleColor.Cyan;
            int num;
            int num2;
            int posicion;
            int numeliminar;
            int posicionEliminar;
            int numBuscar;
            int numEncon;
            List<int> miLista;
            miLista = new List<int>();
            num = CapturaEntero("\n\n\t\tIntroduce un numero entre ", 10, 24);

            Random random = new Random();
            for (int i = 0; i < num; i++)
            {
                miLista.Add(random.Next(10, 100));
            }

            MuestraListaEnColumna(miLista, 4, "Original");
            num2 = CapturaEntero("\n\n\t\tIntroduce un numero entre ", 100, 300);
            posicion = CapturaEntero("\n\n\t\tIntroduce una posicion ", 0, miLista.Count()-1);
            miLista.Insert(posicion, num2);
            MuestraListaEnColumna(miLista, 28, "Modificado");


            Console.SetCursorPosition(2, 25);
            numeliminar = CapturaEntero("\n\n\t\tIntroduce un numero entre para eliminar", 10, 300);

            if (numeliminar == miLista.Count())
            {
                miLista.Remove(numeliminar);
            }
            else if (numeliminar != miLista.Count())
            {
                Console.Write("\n\n\t\tEl numero introducido no existe");
            }

            Console.SetCursorPosition(2, 30);
            posicionEliminar = CapturaEntero("\n\n\t\tIntroduce una posicion para eliminar", 0, miLista.Count()- 1);
            miLista.RemoveAt(posicionEliminar);
            MuestraListaEnColumna(miLista, 40, "Modificada");



            Console.SetCursorPosition(2, 35);
            numBuscar = CapturaEntero("\n\n\t\tIntroduce el numero que quieres buscar", 10, 300);
            numEncon = miLista.IndexOf(numBuscar);

            if (numEncon > 0)
                Console.WriteLine("\n\n\t El numero {0} se encuntra en {1}", numBuscar, numEncon);
            else
                Console.WriteLine("\n\n\t El numero {0} no se encuentra en la lista", numBuscar);
            Pausa("Pulse cualquier letra para salir");

        }
        static void MuestraListaEnColumna(List<int> miLista, int columna, string txt)
        {
            int cont = 8;
            Console.SetCursorPosition(columna, 5);
            Console.Write("{0}", txt);
            for (int i = 0; i < miLista.Count(); i++)
            {
                Console.SetCursorPosition(columna, cont);
                cont++;
                Console.Write("{0}) {1}", i, miLista[i]);
            }
        }
        static void Pausa(string txt)
        {
            Console.SetCursorPosition(2, 40);
            Console.Write(txt);
            Console.ReadKey(true);
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
    }
}
