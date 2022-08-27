using System;
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


    }
}
