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
            int menu = 0;
            int id = 0;
            string text;
            while (true)
            {
                try
                {
                    Console.Write("INGRESA LA CANTIDAD DE DATOS: ");
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
            Arreglos Consultas = new Arreglos(cantidad);
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
                Console.Write("SELECCIONE UNA OPCIÓN:  ");

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
                        try
                        {
                            Consultas.Insert();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("LIMITE");
                        }
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Consultas.Select();
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Consultas.Select();
                        Console.Write("INGRESE EL ÍNDICE A ELIMINAR: ");
                        int indice = Convert.ToInt32(Console.ReadLine());
                        Consultas.Delete(indice - 1);
                        Consultas.Select();

                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("ACTUALIZAR");
                        Consultas.Select();

                        Console.WriteLine("INGRESE EL ÍNDICE DE LA FILA");
                        menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("[1]_ACTUALIZAR NOMBRE");
                        Console.WriteLine("[2]_ACTUALIZAR APELLIDO PATERNO");
                        Console.WriteLine("[3]_ACTUALIZAR APELLIDO MATERNO");
                        Console.WriteLine("[4]_ACTUALIZAR PESO");
                        Console.WriteLine("[5]_ACTUALIZAR ESTATURA");
                        Console.WriteLine("[6]_ACTUALIZAR FECHA DE NACIMIENTO");
                        Console.Write("INGRESA UNA OPCIÓN: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (id == 1)
                        {
                            Consultas.Select();
                            Console.Write("ACTUALIZAR NOMBRE: ");
                            text = Console.ReadLine();
                            Consultas.Update(id, text, menu - 1);
                        }
                        else if (id == 2)
                        {
                            Consultas.Select();
                            Console.Write("ACTUALIZAR APELLIDO PATERNO: ");
                            text = Console.ReadLine();
                            Consultas.Update(id, text, menu - 1);
                        }
                        else if (id == 3)
                        {
                            Consultas.Select();
                            Console.Write("ACTUALIZAR APELLIDO MATERNO: ");
                            text = Console.ReadLine();
                            Consultas.Update(id, text, menu - 1);
                        }
                        else if (id == 4)
                        {
                            Consultas.Select();
                            Console.Write("ACTUALIZAR PESO: ");
                            text = Console.ReadLine();
                            Consultas.Update(id, text, menu - 1);
                        }
                        else if (id == 5)
                        {
                            Consultas.Select();
                            Console.Write("ACTUALIZAR ESTATURA: ");
                            text = Console.ReadLine();
                            Consultas.Update(id, text, menu - 1);
                        }
                        else if (id == 6)
                        {
                            Consultas.Select();
                            Console.Write("ACTUALIZAR FECHA DE NACIMIENTO: ");
                            text = Console.ReadLine();
                            Consultas.Update(id, text, menu - 1);
                        }
                        else
                        {
                            Console.WriteLine("INGRESA UN DATO VALIDO");
                        }
                        Consultas.Select();
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("[1]_PERMUTAR POR ÍNDICE");
                        Console.WriteLine("[2]_PERMUTAR POR NOMBRE");
                        Console.Write("SELECCIONE UNA OPCIÓN: ");
                        try
                        {
                            menu = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("INGRESA UN DATO VALIDO");
                        }
                        if (menu == 1)
                        {
                            Console.WriteLine("PERMUTAR POR ÍNDICE");
                            Consultas.Select();
                            Console.Write("INGRESE EL 1ER ÍNDICE A PERMUTAR: ");
                            int ind1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("INGRESE EL 2DO ÍNDICE A PERMUTAR: ");
                            int ind2 = Convert.ToInt32(Console.ReadLine());
                            Consultas.Exchange(ind1 - 1, ind2 - 1);
                            Consultas.Select();
                        }
                        if (menu == 2)
                        {
                            Console.WriteLine("PERMUTAR POR NOMBRE");
                            Consultas.Select();
                            Console.Write("INGRESE EL 1ER NOMBRE: ");
                            string nm1 = Console.ReadLine();
                            Console.Write("INGRESE EL 2DO NOMBRE: ");
                            string nm2 = Console.ReadLine();
                            Consultas.Exchange(Consultas.GetId(nm1), Consultas.GetId(nm2));
                            Consultas.Select();
                        }
                        else
                        {
                            Console.WriteLine("INGRESA UN DATO VALIDO");
                        }
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("IMC");
                        Consultas.Select();
                        Console.Write("INGRESA EL ÍNDICE: ");
                        menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("EL ÍNDICE DE MASA CORPORAL ES: " + Consultas.GetIMC(menu - 1).ToString());
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("EDAD");
                        Consultas.Select();
                        Console.Write("INGRESA EL ÍNDICE: ");
                        menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("LA EDAD ES DE: "+ Consultas.Age(menu-1).ToString());
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        Console.Clear();
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
