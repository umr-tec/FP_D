using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FPU3D_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar dos variables
            string nombreUsuario;
            byte edadUsuario;

            //Que el suario ingrese por teclado los valores de las variabes
            Console.WriteLine("Ingresa tu nombre, despúes presiona ENTER");
            nombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad, despúes presiona ENTER");
            edadUsuario = Convert.ToByte( Console.ReadLine() );

            //if
            if (edadUsuario > 18)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.WriteLine("Tu código de acceso es: 345678");
            }



            Console.WriteLine("Saliendo del sistema.");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema..");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema...");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema....");
            Thread.Sleep(800);

            // + Hugo, Gael, Eleazar, Nacho, Saul, Karina
            // - Jonathan Carlos Torres, Jorge  Collazo, Mirian, 
        }
    }
}
