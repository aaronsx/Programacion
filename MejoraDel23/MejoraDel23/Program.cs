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
            string persona = string.Empty;
            string Personareal = string.Empty;
            List<string> Alumno = new List<string>();
            string[] Apellidos = { "Sánchez Elegante", "Arenas Mata", "García Solís", "Rodríguez Vázquez", "Hurtado Miranda", 
                                   "Pinto Mirinda", "Barrios Garrobo", "Márquez Salazar", "Medina Gómez", "Alonso Pérez", 
                                   "López Mora", "González Chaparro", "Ferrer Jiménez", "Morales Moncayo", "Fernández Perea", 
                                   "Blanco Roldán", "Navarro Romero", "Aguilar Rubio", "Baena Fernández", "Barco Ramírez", 
                                   "Delgado Rodríguez", "Duque Martínez" };

            string[] Nombres = { "Álvaro", "Daniel Luis", "Juan Manuel", "Agustín", "Fco. Javier", "José Manuel",
                                 "Tomás", "Carlos", "Jose Carlos", "Juan Luis", "Daniel", "Angel", "Jacobo", "Alejandro",
                                 "Francisco", "Alfredo", "Francisco", "Antonio", "Constantino", "Roberto", "Rafael", "Antonio" };
            Alumno = DevuelveListaGente(Apellidos, Nombres);
            MuestraColeccion(Alumno, 4);
            pos1 = CapturaEntero("Introduce la primera posicion que quieres intercambiar", 0, Apellidos.Length - 1);
            LimpiaFila(24);
            pos2 = CapturaEntero("Introduce la primera posicion que quieres intercambiar", 0, Apellidos.Length - 1);
            IntercambiaPos(Alumno, pos1, pos2);
            LimpiaFila(24);
            Console.Write("Introduce la persona que quieres eliminar:  ");
            persona = Console.ReadLine();
            for (int i = 0; i < Alumno.Count(); i++)
            {
                if (persona == Alumno[i])
                    Alumno.Remove(persona);
                
                    
            }
            verdadofalso = BorrarElemento(Alumno, persona);
            Pausa("Salir");
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
                    Console.WriteLine("***ERROR*** Introduce un numero");
                }
                else
                {
                    if (num < min || num > max)
                    {
                        Console.WriteLine("***ERROR*** Introduce un numero que este entre [{0}...{1}]", min, max);
                        ok = false;
                    }

                }
            } while (!ok);
            return num;
        }
        static void LimpiaFila(int fila)
        {
            Console.SetCursorPosition(0, fila);
            Console.Write("                                                                                  ");
            Console.SetCursorPosition(0, fila);
        }
        static List<string> DevuelveListaGente(string[] Apellidos, string[] Nombre)
        {
            List<string> Alumno = new List<string>();
            for (int i = 0; i < Apellidos.Length; i++)
            {
                Alumno.Add(i+")"+ Nombre[i] + " " + Apellidos[i]);
            }
            return Alumno;
        }
        static void MuestraColeccion(List<string> Alumno, int colum)
        {
            for (int i = 0; i < Alumno.Count(); i++)
            {
                Console.SetCursorPosition(colum, i + 2);
                Console.WriteLine(Alumno[i]);
            }

        }
        static void IntercambiaPos(List<string> Alumno, int pos1, int pos2)
        {
            string nombre;
            nombre = Alumno[pos1];
            Alumno[pos1] = Alumno[pos2];
            Alumno[pos2] = nombre;

            MuestraColeccion(Alumno, 38);


        }
        static Boolean BorrarElemento(List<string> Alumno, string persona)
        {

            for (int i = 0; i < Alumno.Count; i++)
            {
                if (persona == Alumno[i])
                {
                    Alumno.Remove(persona);
                    MuestraColeccion(Alumno, 60);
                    return true;
                }
                else
                {
                    Console.WriteLine("Prueba");
                    return false;
                }
                    

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
