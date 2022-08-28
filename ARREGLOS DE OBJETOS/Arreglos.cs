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
                    Alumnos[elementos].AnioNacimiento = new DateTime();
                    Alumnos[elementos].AnioNacimiento = Convert.ToDateTime(dato);
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
                Console.WriteLine("[{0}]_{1}{2}{3}{4}{5}{6}", con = con + 1, Alumnos[i].Nombre.PadRight(15), Alumnos[i].Apellido_p.PadRight(20), Alumnos[i].Apellido_m.PadRight(20), Alumnos[i].Peso.ToString().PadRight(10), Alumnos[i].Estatura.ToString().PadRight(11), Alumnos[i].AnioNacimiento.Year.ToString().PadRight(21));
            }
            Console.ResetColor();
        }

        public void Delete(int p)
        {
            for (int i = p; i < elementos - 1; i++)
            {
                Alumnos[i] = Alumnos[i + 1];
            }
            Alumnos[--elementos].ToString();
        }

        public void Update(int seleccion, string valor, int indice)
        {
            if (seleccion == 1)
            {
                Alumnos[indice].Nombre = valor;
            }
            else if (seleccion == 2)
            {
                Alumnos[indice].Apellido_p = valor;
            }
            else if (seleccion == 3)
            {
                Alumnos[indice].Apellido_m = valor;
            }
            else if (seleccion == 4)
            {
                Alumnos[indice].Peso = Convert.ToDouble(valor);
            }
            else if (seleccion == 5)
            {
                Alumnos[indice].Estatura = Convert.ToDouble(valor);
            }
            else if (seleccion == 6)
            {
                Alumnos[indice].AnioNacimiento = Convert.ToDateTime(valor);
            }
        }

        public void Exchange(int indice1, int indice2)
        {
            Persona aux = Alumnos[indice1];
            Alumnos[indice1] = Alumnos[indice2];
            Alumnos[indice2] = aux;
        }

        public int GetId(string nombre)
        {
            int p = 0;
            for (int i = 0; i < Alumnos.Length; i++)
            {
                if (Alumnos[i].Nombre == nombre)
                {
                    p = i;
                }
            }
            return p;
        }

        public double GetIMC(int id)
        {
            return Math.Round(Alumnos[id].IMC(), 2);
        }

        public int Age(int id)
        {
            return DateTime.Now.Year - Alumnos[id].AnioNacimiento.Year;
        }

        public void SortByText(int opcion, int orden)
        {
            int p;
            if (opcion == 1)
            {
                for (int i = 0; i < elementos; i++)
                {
                    for (int j = 0; j < elementos; j++)
                    {
                        p = string.Compare(Alumnos[i].Nombre, Alumnos[j].Nombre);
                        if (p == orden)
                        {
                            Exchange(i, j);
                        }
                    }
                }
            }
            if (opcion == 2)
            {
                for (int i = 0; i < elementos; i++)
                {
                    for (int j = 0; j < elementos; j++)
                    {
                        p = string.Compare(Alumnos[i].Apellido_p, Alumnos[j].Apellido_p);
                        if (p == orden)
                        {
                            Exchange(i, j);
                        }
                    }
                }
            }
            if (opcion == 3)
            {
                for (int i = 0; i < elementos; i++)
                {
                    for (int j = 0; j < elementos; j++)
                    {
                        p = string.Compare(Alumnos[i].Apellido_m, Alumnos[j].Apellido_m);
                        if (p == orden)
                        {
                            Exchange(i, j);
                        }
                    }
                }
            }
        }

        public void SortById(int id)
        {
            int log = Alumnos.Length - 1;
            bool control = false;
            if (id == 4)
            {
                while (control == false)
                {
                    control = true;
                    for (int i = 0; i < log; i++)
                    {
                        if (Alumnos[i].Peso > Alumnos[i + 1].Peso)
                        {
                            Persona aux = Alumnos[i];
                            Alumnos[i] = Alumnos[i + 1];
                            Alumnos[i + 1] = aux;
                            control = false;
                        }
                    }

                }

            }
            if (id == 5)
            {
                while (control == false)
                {
                    control = true;
                    for (int i = 0; i < log; i++)
                    {
                        if (Alumnos[i].Estatura > Alumnos[i + 1].Estatura)
                        {
                            Persona aux = Alumnos[i];
                            Alumnos[i] = Alumnos[i + 1];
                            Alumnos[i + 1] = aux;
                            control = false;
                        }
                    }

                }
            }
            if (id == 6)
            {
                while (control == false)
                {
                    control = true;
                    for (int i = 0; i < log; i++)
                    {
                        if (Alumnos[i].AnioNacimiento > Alumnos[i + 1].AnioNacimiento)
                        {
                            Persona aux = Alumnos[i];
                            Alumnos[i] = Alumnos[i + 1];
                            Alumnos[i + 1] = aux;
                            control = false;
                        }
                    }

                }
            }
        }
    }
}
