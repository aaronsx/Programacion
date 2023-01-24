using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace P31a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string frase = string.Empty;
            string fichero = string.Empty;


            Console.WriteLine("Introduce el nombre");
            fichero = Console.ReadLine();
            StreamWriter sw = new StreamWriter(string.Format("C:\\Users\\csi22-amunada\\Desktop\\{0}.txt", fichero), false, Encoding.Unicode);
            do 
            { 
                    Console.WriteLine("Introduce una frase para guardarse. Escribe fin para acabar");
                    frase = Console.ReadLine();
                    if (frase != "fin")
                       sw.WriteLine(frase);
 
              
            }while(frase!="fin");
            sw.Close();
           
        }
    }
}
