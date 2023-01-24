/* Leer Datos En Fichero.Txt Con Separadores de Campos: 
Realiza un programa que lea el fichero AlumNotas.txt que tienes en la carpeta Datos. 
Se sabe que cada fila contiene los campos: id, nombre, nota1, nota2 y nota3 separados por ‘;’. 
A partir de estas filas obtenidas, rellena una tabla de byte tabIds, otra de string tabAlums 
y otra de float tabNotas de tres columnas. 
A continuación presentar los datos con su cabecera
 Importante: 
 1.	Utilizar Ruta Relativa y mantener la estructura de archivos que se te entrega. 
 2.	El archivo debe estar abierto el menor tiempo posible.
 3.	Se puede utilizar una lista auxiliar pero tienes que actuar como si no se supiera 
    el número de alumnos que guarda el fichero.
 */
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LeerDatosEnTxtSeparadoresCampo
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            StreamReader sr = new StreamReader(".\\Datos\\AlumNotas.txt");
            //Crear una lista para guardar el archivo
            List<string> listaAux = new List<string>();
            //Esto sirve para ver leer el archivo sr cuando llega al final = null
            while (sr.ReadLine() != null)
            {
                listaAux.Add(sr.ReadLine());
            }
            sr.Close();
            string[] vectorCampos;
            byte[] tabIds = new byte[listaAux.Count];
            string[] tabAlums = new string[listaAux.Count];
            float[,] tabNotas = new float[listaAux.Count, 3];
            for (int i = 0; i < listaAux.Count(); i++)
            {
                vectorCampos = listaAux[i].Split(';');
                tabIds[i] = Convert.ToByte(vectorCampos[0]);
                tabAlums[i] = vectorCampos[1];
                tabNotas[i, 0] = float.Parse(vectorCampos[2]);
                tabNotas[i, 1] = float.Parse(vectorCampos[3]);
                tabNotas[i, 2] = float.Parse(vectorCampos[4]);
            }
            

            //-------------- Mostramos los datos  -----------------

            Console.WriteLine("     Id  Alumno\t\t\t\tProg    Ed      BD      Media");
            Console.WriteLine("     -----------------------------------------------------------------");
            for (int i = 0; i < listaAux.Count(); i++)
            {
                media = Match.Round();
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", tabIds[i], tabAlums[i], tabNotas[i, 0], tabNotas[i, 1], tabNotas[i, 2],media);
            }

        }
    }
}

