using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PruebasMetodosPosicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region--- No tocar este código -------
            for (int f = 10; f < 20; f++)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(0, f);
                Console.Write("{0}                                                                              ", f);
                Console.ResetColor();
                
            }
            #endregion

            //----- Escribe a partir de esta línea tu código de prueba -------
            LimpiaFila(12);
            Pausa("Pulsa una tecla Continuar:",14);
            Print("Pulsa para continuar:", 14, true);
        }

        // Escribe aquí el método
        static void LimpiaFila(int fila)
        {
            Console.SetCursorPosition(0, fila);
            Console.Write("                                                                                  ");
            Console.SetCursorPosition(0, fila);
        }
        static void Pausa(string txt, int fila)
        {
            Console.SetCursorPosition(0,fila);
            Console.Write("                                                                                  ");
            Console.SetCursorPosition(0, fila);
            Console.Write("{0}",txt);
            Console.ReadKey(true);
            Console.SetCursorPosition(0, fila);
            Console.Write("                                                                                  ");
        }
        static void Print(string txt,int fila, bool conReadKey)
        {
            LimpiaFila(fila);
            Console.WriteLine(txt);
            if (conReadKey) 
            {
                Console.ReadKey(true);
            }
            


        }



    }
}
