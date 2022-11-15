using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21b2
{
    internal class Program
    {
        // Alumno: Muñoz Prada, Aaron Senen
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int numDias, diaDeLaSemana, diaDeLaSemanaFinal;
            string nombreDiaSemana = "", nombreDiaSemanaFinal = "";
            string nombre = "";

            MuestraDiasSemana();


            diaDeLaSemana = CapturaOpcion(0, 6);

            nombreDiaSemana = NombreDiaSemana(diaDeLaSemana);

            


            Console.WriteLine("\n\tHoy es {0}", nombreDiaSemana);

            numDias = CapturaOpcion("Introduce cuantos dias quieres avanzar");



            nombreDiaSemanaFinal = ProximoDiaSemana(diaDeLaSemana, numDias);

            Console.WriteLine("\n\tEstamos a {0} y dentro de {1} días será {2}", nombreDiaSemana, numDias, nombreDiaSemanaFinal);
            


            Console.Write("\n\n\t\tPulsa Intro para salir");
            Console.ReadLine();
        }
        static void MuestraDiasSemana()
        {
            Console.WriteLine("\n\t\t0) Domingo");
            Console.WriteLine("\n\t\t1) Lunes");
            Console.WriteLine("\n\t\t2) Martes");
            Console.WriteLine("\n\t\t3) Miércoles");
            Console.WriteLine("\n\t\t4) Jueves");
            Console.WriteLine("\n\t\t5) Viernes");
            Console.WriteLine("\n\t\t6) Sábado");

        }

        static int CapturaOpcion(int min, int max)
        {
            int diaDeLaSemana;
            Console.Write("\n\t\tPulse su opcion: ");
            diaDeLaSemana = Convert.ToInt32(Console.ReadLine());

            while (diaDeLaSemana < min || diaDeLaSemana > max)
            {
                Console.WriteLine("\n\t\t** Error: No ha introducido una opción correcta **");
                Console.Write("\n\t\tPulse su opcion: ");
                diaDeLaSemana = Convert.ToInt32(Console.ReadLine());
            }
            return diaDeLaSemana;

        }
        static int CapturaOpcion(string txt)
        {
            int diaDeLaSemana;
            bool numok;
            do {
                Console.Write("{0}: ", txt);
                numok = Int32.TryParse(Console.ReadLine(), out diaDeLaSemana);
                if(!numok ) 
                {
                    Console.WriteLine("\n\t\t** Error: No ha introducido un valor correcto**");
                }
                else if (diaDeLaSemana < 1)
                {
                    Console.WriteLine("\n\t\t** Error: Debes avanzar al menos un dia **");

                    numok = false;
                }
            }while(!numok);
            
            return diaDeLaSemana;

        }

        static string NombreDiaSemana(int idDiaSemana)
        {
            switch (idDiaSemana)
            {
                case 0:
                    return "Domingo";
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
            }
            return "";
        }

        static string ProximoDiaSemana(int idDiaSemana, int diasAvance)
        {
            string nombreDiaSemana = String.Empty;
            int diaDeLaSemanaFinal = (diasAvance + idDiaSemana) % 7;

            nombreDiaSemana = NombreDiaSemana(diaDeLaSemanaFinal);

            return nombreDiaSemana;
        }
    }
}
