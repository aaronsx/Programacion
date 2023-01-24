using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEjemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(154);


            Pausa("salir");
        }
        static void Pausa(string txt)
        {
            Console.Write("\n\n\t\tPulse cualquier tecla para {0}", txt);
            Console.ReadKey(true);
        }
    }
}
