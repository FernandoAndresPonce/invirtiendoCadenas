using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invirtiendoCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crea un programa que invierta el orden de una cadena de texto
             * sin usar funciones propias del lenguaje que lo hagan de forma automática.
             * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
             */

            Console.WriteLine("\nINVIRTIENDO CADENAS\n");

            string texto, textoInvertido;

            Console.Write("Ingrese el texto que desea invertir: ");
            texto = Console.ReadLine();

            // Sin funcion.
            //char[] caracteresTexto = texto.ToCharArray();
            //int longitud = caracteresTexto.Length;
            //char[] invertirCaracteresTexto = new char[longitud];

            //for (int x = 0; x < longitud; x++)
            //{
            //    invertirCaracteresTexto[x] = caracteresTexto[longitud - 1 - x];

            //}

            //for (int x = 0; x < invertirCaracteresTexto.Length; x++)
            //{
            //    Console.WriteLine(invertirCaracteresTexto[x]);
            //}

            //Uso de funcion.
            textoInvertido = new string (Invertir(texto));

            Console.WriteLine("\nTEXTO INVERTIDO: " + textoInvertido);
            Console.WriteLine("\nGracias por usar mi programa.\n");
            Console.ReadKey();

        }

        // Con funcion.
        static char[] Invertir(string texto)
        {
            char[] caracteresTexto = texto.ToCharArray();
            int longitud = caracteresTexto.Length;
            char[] invertirCaracteresTexto = new char[longitud];

            for (int x = 0; x < longitud; x++)
            {
                invertirCaracteresTexto[x] = caracteresTexto[longitud - 1 - x];

            }

            return invertirCaracteresTexto;
            

        }
    }
}
