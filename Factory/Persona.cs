using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Persona
    {
        public abstract int ID { get; set; }
        public abstract  string IDENTIFICACION { get; set; }
        public abstract string NOMBRE { get; set; }
        public abstract string APELLIDO { get; set; }
        public abstract  int EstadoCivil { get; set; }

        public abstract DateTime  FechaNacimiento { get; set; }
        public abstract  string DIRECCION { get; set; }
        public abstract string TELEFONO { get; set; }
        public abstract  int Sexo { get; set; }
        public abstract string EMAIL { get; set; }

    }
}
