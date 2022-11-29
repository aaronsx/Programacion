using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22f1
{
    // Alumno: Muñoz Prada, Aaron Senen
    internal class P22f2_Muñoz_Aaron
    {
        static void Main(string[] args)
        {
            int dia=0;
            int mes = 0;
            int anyo = 0;
            Console.ForegroundColor= ConsoleColor.Cyan;

            CapturaFechaString( dia,  mes,  anyo);
            Salir();
        }
        static int CapturaEntero(string txt)
        {
            bool ok;
            int num=0;
            Console.Write("{0}",txt);
            ok = Int32.TryParse(Console.ReadLine(), out num);
            if(!ok) 
            {
                Console.WriteLine("\t\t\n\n***ERROR*** introduce un numero");
            }
            return num;
        }
        static void CapturaFechaString(int dia, int mes, int anyo)
        {
            bool ok;
            string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
           
           
            string mess = String.Empty;
           

            anyo = CapturaEntero("\t\t\n\nIntroduce un año:");
            
            
            do
            {
                mes = CapturaEntero("\t\t\n\nIntroduce un mes:");
                switch (mes)
                {
                    case 1:
                        mess = Meses[0];
                        break;
                    case 2:
                        mess = Meses[1];
                        break;
                    case 3:
                        mess = Meses[2];
                        break;
                    case 4:
                        mess = Meses[3];
                        break;
                    case 5:
                        mess = Meses[4];
                        break;
                    case 6:
                        mess = Meses[5];
                        break;
                    case 7:
                        mess = Meses[6];
                        break;
                    case 8:
                        mess = Meses[7];
                        break;
                    case 9:
                        mess = Meses[8];
                        break;
                    case 10:
                        mess = Meses[9];
                        break;
                    case 11:
                        mess = Meses[10];
                        break;
                    case 12:
                        mess = Meses[11];
                        break;


                }
            } while (mes > 12);
            do
            {
                dia = CapturaEntero("\t\t\n\nIntroduce un dia:");
                ok = true;
                
                if (anyo % 4 == 0 && anyo % 100 != 0 || anyo % 400 == 0)
                {
                    if ((dia < 1 || dia > 31) || (dia == 31 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 29 && mes == 2))
                    {
                        Console.WriteLine("\n\t\t** Error: día Fuera de rango **"); 
                        ok = false;
                    }
                    else if(ok)
                    Console.WriteLine("\n\t\t\nEl año {0} es bisiesto  ", anyo);
                }
                else
                {
                    if ((dia < 1 || dia > 31) || (dia == 31 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 28 && mes == 2))
                    {
                        Console.WriteLine("\n\t\t** Error: día Fuera de rango **");
                        ok = false;
                    }
                    else if (ok)
                        Console.WriteLine("\n\t\t\nEl año {0} no es bisiesto  ", anyo);
                }
                
            } while (!ok);


         Console.WriteLine("\n\n\t\t La fecha es: {0} de {1} de {2} ", dia, mess, anyo);

        }
        static void Salir()
        {
            Console.ReadLine();
            Console.Clear();
            Console.Write("\n\n\t\tPulsa Intro para salir");
            Console.ReadLine();
        }
    }
}
