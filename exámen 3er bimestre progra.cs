using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exámen_progra
{
    class Program
    {
        static string[,] Usuarios = new string[4, 10];
        static void Main(string[] args)
        {
            int opci;

            Console.WriteLine("Por favor escoja una opción");
            Console.WriteLine("\n");

            Console.WriteLine("1.Crear contacto");
            Console.WriteLine("2.Ver contactos");
            Console.WriteLine("3.Buscar contacto que desee");
            Console.WriteLine("5.Salir");
            Console.WriteLine("\n");
            opci = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();

            while (opci != 4)
            {
                int continuar;
                string b;
                int m;


                for (int x = 0; x < 1; x++)
                {
                    Console.WriteLine("Por favor, ingrese su nombre:");
                    Usuarios[0, x] = Console.ReadLine();
                    Console.WriteLine(" \n");
                    Console.WriteLine("Por favor, ingrese su apellido:");
                    Usuarios[1, x] = Console.ReadLine();
                    Console.WriteLine(" \n");
                    Console.WriteLine("Por favor, ingrese su dirección");
                    Usuarios[2, x] = Console.ReadLine();
                    Console.WriteLine(" \n");
                    Console.WriteLine("Por favor, ingrese su telefono");
                    Usuarios[3, x] = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Presiona enter para continuar o 4 para salir :)");
                    Console.ReadKey();
                    Console.Clear();
                    try
                    { 

                        continuar = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Incorrecto, por favor presione *Enter* para continuar o *4* para salir");
                       continuar = int.Parse(Console.ReadLine());
                    }

                    if (continuar == 1)
                    {

                        break;
                    }

                    Console.Clear();
                }
                Console.WriteLine("1.Para buscar contacto");
                Console.WriteLine("2.para Ver contacto 2");
                Console.WriteLine("3.Para salir 4");
                m = int.Parse(Console.ReadLine());
                if (m == 1)
                    for (int x = 0; x < 10; x++)
                    {
                        Console.WriteLine(" Nombre: " + Usuarios[0, x] + " Apellido: " + Usuarios[1, x] + " Dirección: " + Usuarios[2, x] + " telefono: " + Usuarios[3, x] + "\n");
                        
                    }

                while (m != 3)
                {
                    if (m == 2)
                    {
                        for (int x = 0; x < 1; x++)
                        {
                            Console.WriteLine("Ingrese el nombre para mostrar contacto");
                            b = Console.ReadLine();
                            if (b == Usuarios[0, x])
                            {
                                Console.WriteLine(" Nombre: " + Usuarios[0, x] + " Apellido: " + Usuarios[1, x] + " Dirección: " + Usuarios[2, x] + " telefono: " + Usuarios[3, x] + "\n");
                                Console.WriteLine("1.Para ver usuarios escriba: 1 ");
                                Console.WriteLine("2.para buscar usuarios escriba: 2");
                                Console.WriteLine("3.Salir");
                                try
                                {
                                    m = int.Parse(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Error, por favo inténtelo de nuevo");
                                    m = int.Parse(Console.ReadLine());
                                }



                            }





                        }


                    }

                }
            }

        }
    }
}

