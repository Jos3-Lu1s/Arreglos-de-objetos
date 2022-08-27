using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARREGLOS_DE_OBJETOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            int control = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("INGRESA LA CANTIDAD DE DATOS: ");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESA UN DATO NUMÉRICO VALIDO: ");
                }
            }

            do
            {
                Console.WriteLine("╔═╗╦═╗╦═╗╔═╗╔═╗╦  ╔═╗╔═╗  ╔╦╗╔═╗  ╔═╗╔╗  ╦╔═╗╔╦╗╔═╗╔═╗");
                Console.WriteLine("╠═╣╠╦╝╠╦╝║╣ ║ ╦║  ║ ║╚═╗   ║║║╣   ║ ║╠╩╗ ║║╣  ║ ║ ║╚═╗");
                Console.WriteLine("╩ ╩╩╚═╩╚═╚═╝╚═╝╩═╝╚═╝╚═╝  ═╩╝╚═╝  ╚═╝╚═╝╚╝╚═╝ ╩ ╚═╝╚═╝");
                Console.WriteLine("[1]_INSERTAR");
                Console.WriteLine("[2]_MOSTRAR");
                Console.WriteLine("[3]_ELIMINAR");
                Console.WriteLine("[4]_ACTUALIZAR");
                Console.WriteLine("[5]_PERMUTAR");
                Console.WriteLine("[6]_IMC");
                Console.WriteLine("[7]_EDAD");
                Console.WriteLine("[8]_ORDENAR");
                Console.WriteLine("[9]_SALIR");
                Console.WriteLine("SELECCIONE UNA OPCIÓN:  ");

                try
                {
                    control = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("INTRODUCE DATOS VALIDOS");
                }
                switch (control)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    default:
                        Console.Clear();
                        break;
                }

            } while (control != 9);
        }
    }
}
