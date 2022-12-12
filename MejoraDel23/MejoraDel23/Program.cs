using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MejoraDel23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            bool verdadofalso;
            int pos1 = 0;
            int pos2 = 0;
            string persona=string.Empty;
            string Personareal=string.Empty;
            List<string> Alumno = new List<string>();
            string[] Apellidos = {"Sanchez Elegante", "Arenas Matas", "Garcia Salis" };
            string[] Nombres = {"Alvaro","Antonio","Juan" };
            Alumno = DevuelveListaGente(Apellidos, Nombres);
            MuestraColeccion(Alumno, 4);
            pos1 = CapturaEntero("Introduce la primera posicion que quieres intercambiar", 0, Apellidos.Length - 1);
            pos2 = CapturaEntero("Introduce la primera posicion que quieres intercambiar", 0, Apellidos.Length - 1);
            IntercambiaPos(Alumno, pos1, pos2);
            
            Console.Write("Introduce la persona que quieres eliminar");
            persona = Console.ReadLine();
            for (int i = 0; i < Alumno.Count(); i++)
            {
                if (persona == Alumno[i])
                    Personareal= persona ;
                else
                    Console.WriteLine("No existe la persona");
            }
            verdadofalso = BorrarElemento(Alumno, Personareal);
            Pausa("Salir");
        }
        
        static int CapturaEntero(string txt, int min, int max)
        {
            bool ok;
            int num;
            do { 
                Console.WriteLine("{0} [{1}...{2}]",txt,min,max);
                ok=Int32.TryParse(Console.ReadLine(), out num);
                if(!ok) 
                {
                    Console.WriteLine("***ERROR*** Introduce un numero");
                }
                else
                {
                    if(num<min||num>max)
                    {
                        Console.WriteLine("***ERROR*** Introduce un numero que este entre [{0}...{1}]",min,max);
                        ok = false;
                    }

                }
            } while (!ok);
            return num;
        }
        static List<string> DevuelveListaGente(string[] Apellidos, string[] Nombre)
        {
            List<string> Alumno = new List<string>();
            for (int i=0; i<Apellidos.Length;i++)
            {
                Alumno.Add(Apellidos[i]+" "+ Nombre[i]);
            }
            return Alumno;
        }
        static void MuestraColeccion(List<string> Alumno, int colum)
        {
            for (int i = 0; i < Alumno.Count(); i++)
            {
               Console.SetCursorPosition(colum, i+2);
                Console.WriteLine(Alumno[i]);
            }
            
        }
        static void IntercambiaPos(List<string> Alumno, int pos1, int pos2)
        {
            string nombre;
            nombre = Alumno[pos1];
            Alumno[pos1] = Alumno[pos2];
            Alumno[pos2] = nombre;

            MuestraColeccion(Alumno, 30);


        }
        static Boolean BorrarElemento(List<string> Alumno, string persona)
        {
         
            for(int i=0; i< Alumno.Count; i++) 
            {
                if (persona == Alumno[i])
                {
                    Alumno.Remove(persona);
                    MuestraColeccion(Alumno, 30);
                    return true;
                }
                else
                    return false;
                
            }
            return false;
        }
        static void Pausa(string texto)
        {
            Console.WriteLine("\t\t\n\nPulsa una tecla para " + texto);
            Console.ReadKey(true);
        }

    }
}
