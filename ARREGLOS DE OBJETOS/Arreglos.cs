﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARREGLOS_DE_OBJETOS
{
    class Arreglos
    {
        private Persona[] Alumnos;
        private int elementos;
        public Arreglos(int t)
        {
            Alumnos = new Persona[t];
            elementos = 0;
        }
        public void Insert()
        {
            Alumnos[elementos] = new Persona();
            Console.WriteLine("NOMBRE: ");
            Alumnos[elementos].Nombre = Console.ReadLine();
            Console.WriteLine("APELLIDO PATERNO: ");
            Alumnos[elementos].Apellido_p = Console.ReadLine();
            Console.WriteLine("APELLIDO MATERNO: ");
            Alumnos[elementos].Apellido_m = Console.ReadLine();
            Console.WriteLine("PESO: ");
            Alumnos[elementos].Peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ESTATURA: ");
            Alumnos[elementos].Estatura = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("FECHA DE NACIMIENTO: ");
                string dato = Console.ReadLine();
                if (dato.Length == 10)
                {
                    Alumnos[elementos].AñoNacimiento = new DateTime();
                    Alumnos[elementos].AñoNacimiento = Convert.ToDateTime(dato);
                    break;
                }
                else
                {
                    Console.WriteLine("INGRESA UN DATO VALIDO");
                }
            }
            elementos++;
        }

        public void Select()
        {
            int con = 0;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("[*]_" + "NOMBRE".PadRight(15) + "APELLIDO PATERNO".PadRight(20) + "APELLIDO MATERNO".PadRight(20) + "PESO".PadRight(10) + "ESTATURA".PadRight(11) + "FECHA DE NACIMIENTO".PadRight(21));
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < elementos; i++)
            {
                Console.WriteLine("[{0}]_{1}{2}{3}{4}{5}{6}", con = con+1, Alumnos[i].Nombre.PadRight(15), Alumnos[i].Apellido_p.PadRight(20), Alumnos[i].Apellido_m.PadRight(20), Alumnos[i].Peso.ToString().PadRight(10), Alumnos[i].Estatura.ToString().PadRight(11), Alumnos[i].AñoNacimiento.Year.ToString().PadRight(21));
            }
            Console.ResetColor();
        }
    }
}
