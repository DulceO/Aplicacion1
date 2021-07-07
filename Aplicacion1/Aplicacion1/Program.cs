using System;

namespace Aplicacion1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Agenda");
            Console.WriteLine("");

            string[,] agenda = new string[5, 15];

            for (int f = 0; f < 15; f++)
            {
                Console.Write("Nombre: ");
                agenda[0, f] = Console.ReadLine();
                Console.Write("Apellido: ");
                agenda[1, f] = Console.ReadLine();
                Console.Write("Diercción: ");
                agenda[2, f] = Console.ReadLine();
                Console.Write("Numero: ");
                agenda[3, f] = Console.ReadLine();
                Console.Write("Correo: ");
                agenda[4, f] = Console.ReadLine();
                Console.WriteLine("");
            }

            Console.WriteLine("Ingresa un nombre, apellido, direccion, numero o correo.");
            string buscar = Console.ReadLine();
            for (int z = 0; z <= 14; z++)
            {
                if (agenda[z, z] == buscar)
                {
                    Console.Write("dato" + buscar + "encontrado");
                }
            }
            Console.ReadKey();
        }
    }
}
            







            