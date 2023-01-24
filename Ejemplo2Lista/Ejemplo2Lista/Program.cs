using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2Lista
{
    internal class Program
    {
        static int ultimaFila;
        static void Main(string[] args)
        {
            List<char>listaChar; // después de esto listInt vale null
                               //miLista[2] = 23; // Error porque no está construida
           listaChar = new List<char>(); // ¡¡Construida!! 
                                       //miLista[2] = 23; // Error porque no existe ninguna posición (está vacía)

           
           
            // Pedimos al usuario el número de elementos que queremos:
            int numElements = CapturaEntero("¿Número de elementos:", 10, 24);

            // la cargamos con esa cantidad de elementos al azar de tres cifras
            Pausa("CARGAR la lista con " + numElements + " enteros al azar de tres cifras");
            Console.Clear();
            Random azar = new Random();

            for (int i = 0; i < numElements; i++)
                listaChar.Add((char)azar.Next((int)'A', (int)'Z'+1));

            // Mostramos la lista en la columna 4
            MuestraListaEnColumna(listaChar, 4, "ORIGINAL");


            // Mostramos la lista a la derecha de la anterior
            MuestraListaEnColumna(listaChar, 14, "INSERT(3)");

            //--- Ordenamos la lista
            Pausa("ORDENAR la lista");
            listaChar.Sort();
            // Mostramos la lista a la derecha de la anterior
            MuestraListaEnColumna(listaChar, 24, "ORDENADA");

            //--- Invertimos la lista
            Pausa("INVERTIR la lista");
            listaChar.Reverse();
            // Mostramos la lista a la derecha de la anterior
            MuestraListaEnColumna(listaChar, 34, "INVERTIDA");

            // --- Eliminar un elemento indicando el elemento, no la posición.
            Pausa("ELIMINAR algún elemento");
            // si no existe, pido otro
            // Una forma de hacerlo: comprobando primero si existe
            bool existe;
            int numBorrar = CapturaEntero("Dime el número a borrar", 10, 99);
            existe = listaChar.Contains(numBorrar);
            while (!existe)
            {
                Console.WriteLine("\n\t ** El número {0} no existe en la lista **", numBorrar);

                numBorrar = CapturaEntero("Dime el número a borrar", 10, 99);
                existe = listaChar.Contains(numBorrar);
            }
            Console.WriteLine("\n\t El número {0} estaba en la posición {1} en la lista **", numBorrar, listaChar.IndexOf(numBorrar));
            listaChar.Remove(numBorrar);
            // Mostramos la lista a la derecha de la anterior
            MuestraListaEnColumna(listaChar, 44, "BORRAR 1");

            // Otra forma de hacerlo: comprobando si lo ha podido borrar
            do
            {
                numBorrar = CapturaEntero("¿número a eliminar?:", 10, 99);
                existe = listaChar.Remove(numBorrar);
                if (!existe)
                    Console.WriteLine("\nEl número {0} no existe en la lista. ¿No lo estás viendo?", numBorrar);
            } while (!existe);

            Console.WriteLine("\n\t El número {0} ha sido eliminado ", numBorrar);
            listaChar.Remove(numBorrar);

            // Mostramos la lista a la derecha de la anterior
            MuestraListaEnColumna(listaChar, 54, "BORRAR 2");

            //---- eliminar un elemento indicando  la posición.
            int pos = CapturaEntero("¿Posición del elemento a eliminar?:", 0, listaChar.Count - 1);

            listaChar.RemoveAt(pos);

            // Mostramos la lista a la derecha de la anterior
            MuestraListaEnColumna(listaChar, 64, "BORRAPOS");

            //---- eliminar varios elementos a partir de una posición
            pos = CapturaEntero("¿Posición inicial de  elementos a eliminar?:", 0, listaChar.Count - 1);
            int cantidad = CapturaEntero("¿Cantidad de elementos a eliminar?:", 0, listaChar.Count - pos);
            listaChar.RemoveRange(pos, cantidad);

            // Mostramos la lista a la derecha de la anterior
            MuestraListaEnColumna(listaChar, 74, "BORRANGO");

            // --- Buscar un elemento.
            Pausa("BUSCAR algún elemento");
            int numBuscar = CapturaEntero("¿Número a buscar?:", 10, 99);
            pos = listaChar.IndexOf(numBuscar);
            while (pos == -1)
            {
                Console.WriteLine("\nEl número {0} no existe en la lista", numBorrar);
                numBuscar = CapturaEntero("¿Número a buscar?:", 10, 99);
                pos = listaChar.IndexOf(numBuscar);
            }
            Console.WriteLine("\n\t El número {0} ESTÁ en la posición {1} en la lista **", numBuscar, pos);

            /*---- A OBSERVAR LAS VENTAJAS LOS MÉTODOS ----
                •  Ahorro de Número de líneas de código
                •  Claridad
                •  Fácil mantenimiento
            */
            Console.WriteLine("\n\n\t\tPulsa intro para salir");
            Console.ReadLine();
        }


        static void MuestraListaEnColumna(List<char> lisEnt, int columna, string cabecera)
        {
            int i = 0;
            Console.SetCursorPosition(columna, 0);
            Console.Write(cabecera);
            // Mostramos los valores de la lista
            for (i = 0; i < lisEnt.Count; i++)
            {
                Console.SetCursorPosition(columna, i + 1);
                if (i < 10)
                    Console.Write(" ");
                Console.Write("{0}) {1}", i, lisEnt[i]);
            }
        }

        static void Pausa(string texto)
        {
            Console.WriteLine("\n\n   Pulsa una tecla para " + texto);
            Console.ReadKey(true); // <-- true porque NO quiero que se vea la tecla pulsada
        }

        static int CapturaEntero(string texto, int min, int max)
        {
            int miEntero;
            bool esEntero;

            do
            {
                Console.Write("\n\t{0} [{1}..{2}]: ", texto, min, max);
                esEntero = int.TryParse(Console.ReadLine(), out miEntero);

                if (!esEntero)  // Comprobamos el formato
                    Console.WriteLine("\n** Error. no ha introducido un número entero **");
                else if (miEntero < min || miEntero > max) // Comprobamos el rango
                    Console.WriteLine("\n** Error. Valor fuera de rango **");

            } while (!esEntero || miEntero < min || miEntero > max);

            return miEntero;
        }
    }
}
