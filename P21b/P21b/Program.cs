using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P21b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int numDias=0, diaDeLaSemana, diaDeLaSemanaFinal;
            string nombreDiaSemana = "", nombreDiaSemanaFinal = "";

            MuestraDiasSemana();
            diaDeLaSemana = CapturaOpcion("\n\tIntroduce un dia de la semana:");
            nombreDiaSemana = NombreDiaSemana(diaDeLaSemana);
            ProximoDiaSemana(diaDeLaSemana, nombreDiaSemana, numDias);

         
            

            

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
        static int CapturaOpcion(string txt)
        {
            int Dia;
             Console.Write(txt);
            Dia=Convert.ToInt32(Console.ReadLine());
            return Dia;
        }
        static string NombreDiaSemana(int idDiaSemana)
        {
            string nombreDiaSemna=string.Empty;
            switch (idDiaSemana)
            {
                case 0:
                    nombreDiaSemna = "Domingo"; break;
                case 1:
                    nombreDiaSemna = "Lunes"; break;
                case 2:
                    nombreDiaSemna = "Martes"; break;
                case 3:
                    nombreDiaSemna = "Miércoles"; break;
                case 4:
                    nombreDiaSemna = "Jueves"; break;
                case 5:
                    nombreDiaSemna = "Viernes"; break;
                case 6:
                    nombreDiaSemna = "Sábado"; break;
                default:
                    Console.WriteLine("Valor incorrecto"); break;
            }
            return nombreDiaSemna;
        }
        static void ProximoDiaSemana(int idDiaSemana, string Dia, int numdia)
        {
            int diaf;
            if (idDiaSemana >= 0 && idDiaSemana <= 6)
            {
                Console.WriteLine("\n\tHoy es {0}", Dia);

                Console.Write("\tIntroduce cuántos días quieres avanzar: ");
                numdia = Convert.ToInt32(Console.ReadLine());

                if (numdia > 0)
                {

                    diaf = (numdia + idDiaSemana) % 7;
                    string diaff = string.Empty;
                    switch (diaf)
                    {
                        case 0:
                            diaff = "Domingo"; break;
                        case 1:
                            diaff = "Lunes"; break;
                        case 2:
                            diaff = "Martes"; break;
                        case 3:
                            diaff = "Miércoles"; break;
                        case 4:
                            diaff = "Jueves"; break;
                        case 5:
                            diaff = "Viernes"; break;
                        case 6:
                            diaff = "Sábado"; break;
                    }
                    Console.WriteLine("\n\tEstamos a {0} y dentro de {1} días será {2}", Dia, numdia, diaff);
                }
                else Console.WriteLine("\n\t¡¡Avanzar significa un número de días mayor de cero!!");
            }
            
        }

    
    }
}
