using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARREGLOS_DE_OBJETOS
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido_p { get; set; }
        public string Apellido_m { get; set; }
        public double Peso { get; set; }
        public double Estatura { get; set; }
        public DateTime AñoNacimiento { get; set; }
        
        public double IMC()
        {
            return Peso / Math.Pow(Estatura / 100, 2);
        }
    }
}
