using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22o
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Cyan;
            string[] vApellidos = {"Sánchez Elegante", "Arenas Mata", "García Solís","Rodríguez Vázquez",
                                   "Hurtado Miranda", "Pinto Mirinda", "Barrios Garrobo", "Márquez Salazar", 
                                   "Medina Gómez", "Alonso Pérez", "López Mora", "González Chaparro", "Ferrer Jiménez", 
                                   "Morales Moncayo", "Fernández Perea", "Blanco Roldán", "Navarro Romero", "Aguilar Rubio", 
                                   "Baena Fernández", "Barco Ramírez", "Delgado Rodríguez", "Duque Martínez" };
            
            string[] vNombres = {"Álvaro", "Daniel Luis", "Juan Manuel", "Agustín", "Fco. Javier",
                                 "José Manuel", "Tomás", "Carlos", "Jose Carlos", "Juan Luis", "Daniel",
                                 "Angel", "Jacobo", "Alejandro", "Francisco", "Alfredo", "Francisco",
                                 "Antonio", "Constantino", "Roberto", "Rafael", "Antonio"};



            string[,] tab2dGente = new string[vApellidos.Length, 2];

            for (int i=0; i<vApellidos.Length; i++) 
            {
                tab2dGente[i, 0] = vNombres[i];
                tab2dGente[i, 1] = vApellidos[i];
            }
            for (int i = 0; i < tab2dGente.GetLength(0); i++)
            {
                Console.WriteLine("\t{0}) {1} {2}",(i+1).ToString("00") ,tab2dGente[i,0], tab2dGente[i,1]);
            }
            Console.WriteLine("\n\n\t\tEspacio\n\n");
            string[] vApellNomb = new string [vApellidos.Length];
            for (int i = 0; i < tab2dGente.GetLength(0); i++)
            {
                vApellNomb[i] = String.Format("{0}, {1}", tab2dGente[i, 1], tab2dGente[i, 0]);
                Console.WriteLine("\t{0}) {1}", (i + 1).ToString("00"), vApellNomb[i]);
            }
            string anterior = string.Empty;
            for (int i = 0; i < vApellNomb.Length; i++)
            {
                
                if (anterior.Length < vApellNomb[i].Length)
                    anterior = vApellNomb[i];
                
            }
            Console.WriteLine("\tel caracter mas grande es {0} ",anterior);
            Pausa("salir");
            
            
            
        }

        static void Pausa(string txt)
        {
            Console.Write("\nPulse una tecla para {0}", txt);
            Console.ReadKey(true);
        }

    }
}
