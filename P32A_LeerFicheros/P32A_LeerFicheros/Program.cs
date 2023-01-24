using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P32A_LeerFicheros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            StreamReader sr = File.OpenText(CapturaRuta());
            int numLineas = 0;
            string lineaMayor = String.Empty;
            while (sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
                numLineas++;
                if (sr.ReadLine().Length > lineaMayor.Length)
                {
                    lineaMayor = sr.ReadLine();
                }
            }
 
            sr.Close();
        }
        static string CapturaRuta()
        {
            string ruta;
            do
            {
                Console.WriteLine("Introduce un nombre del chero");
                ruta = Console.ReadLine();
                if (!File.Exists(String.Format("C:\\zDatosPruena\\{0}", ruta)))
                    Console.WriteLine("***ERROR***La ruta ya existe");

            } while (!File.Exists(String.Format("C:\\zDatosPruena\\{0}", ruta)));

            return String.Format("C:\\zDatosPruena\\{0}", ruta);
        }

    }
    
}
