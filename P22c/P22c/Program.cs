using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22c
{
    internal class Program
    {
        static int diaDeLaSemanaFinal;
        static string nombreDiaSemanaFinal = "";
        static string[] diaSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int numDias = 0, diaDeLaSemana;
            
            
            MuestraDiasSemana();
            diaDeLaSemana = CapturaOpcion("\n\tIntroduce un dia de la semana:");
            ProximoDiaSemana( diaSemana, diaDeLaSemana, numDias);






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
            Dia = Convert.ToInt32(Console.ReadLine());
            
            return Dia;
        }
        
        static void ProximoDiaSemana(string[] diaSemana, int idDiaSemana, int numdia)
        {
            
            int diaf;
            if (idDiaSemana >= 0 && idDiaSemana <= 6)
            {
                Console.WriteLine("\n\tHoy es {0}", diaSemana[idDiaSemana]);

                Console.Write("\tIntroduce cuántos días quieres avanzar: ");
                numdia = Convert.ToInt32(Console.ReadLine());

                if (numdia > 0)
                {

                    diaf = (numdia + idDiaSemana) % 7;
                    string diaff = string.Empty;
                    switch (diaf)
                    {
                        case 0:
                            diaff =  diaSemana[0]; break;
                        case 1:
                            diaff = diaSemana[1]; break;
                        case 2:
                            diaff = diaSemana[2]; break;
                        case 3:
                            diaff = diaSemana[3]; break;
                        case 4:
                            diaff = diaSemana[4]; break;
                        case 5:
                            diaff = diaSemana[5]; break;
                        case 6:
                            diaff = diaSemana[6]; break;
                    }
                    Console.WriteLine("\n\tEstamos a {0} y dentro de {1} días será {2}", diaSemana[idDiaSemana], numdia, diaff);
                }
                else Console.WriteLine("\n\t¡¡Avanzar significa un número de días mayor de cero!!");
            }

        }


    }
}
