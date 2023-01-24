using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P33a_EscribirDatosEnTxtConSeparadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string[] tApell = {"Sánchez Elegante", "Arenas Mata", "García Solís", "Rodríguez Vázquez",
                "Hurtado Miranda", "Pinto Mirinda", "Barrios Garrobo", "Márquez Salazar", "Medina Gómez",
                "Alonso Pérez", "López Mora", "González Chaparro", "Ferrer Jiménez", "Morales Moncayo",
                "Fernández Perea", "Blanco Roldán", "Navarro Romero", "Aguilar Rubio", "Baena Fernández",
                "Barco Ramírez", "Delegado Rodríguez", "Duque Martínez"};
            string[] tNomb = {"Álvaro", "Daniel Luis", "Juan Manuel", "Agustín", "Fco. Javier", "José Manuel", "María", "Carlos",
                "Jose Carlos", "Juan Luis", "Daniel", "Carmen", "Jacobo", "Alejandro", "Francisco", "Alicia", "Francisco", "Ángela",
                "Constantino", "Mariló", "Rafaela", "Antonio"};
            byte[] tIds= new byte[tApell.Length];
            float[,] tNotas= new float[tApell.Length, 3];
            string[] VectorDeAlumnos = new string[tApell.Length];
            string VectorDeAlumno;
            StreamWriter sW;
            sW = File.CreateText("C:\\zDatosPruebas\\fNotasCS.TXT");
            //Generar ids sin repetir
            byte num;
            Random random = new Random();
            bool[] vAux = new bool[100];// <-- Todos quedarán a false

            for (int i = 0; i < tIds.Length; i++)
            {

                do
                {
                    num = Convert.ToByte(random.Next(10, 100));

                }
                while (vAux[num]);

                vAux[num] = true;
                tIds[i] = num;
            }
            //tNotas
            for(int i=0;i<2;i++)
            {
                 tNotas[i,0] = random.Next(100)*0.1f;
                 tNotas[i,1] = random.Next(100) * 0.1f;
                 tNotas[i,2] = random.Next(100) * 0.1f;
            }
            for (int i = 0; i < tIds.Length; i++)
            {
                sW.WriteLine("{0};{1};{2};{3};{4};{5}", tIds[i], tApell[i], tNomb[i], tNotas[i,0 ], tNotas[i,1], tNotas[i,2]);
                
            }
            sW.Close();
            
            
        }
    }
}
