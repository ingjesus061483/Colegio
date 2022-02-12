using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
   public  class Usuario:Persona
    {
        public override  int ID { get; set; }
        public override int Sexo { get; set; }

        [Display(Name = "Identificacion")]
        public  override string IDENTIFICACION { get; set; }

        [Display(Name = "Nombre")]
        public override string NOMBRE { get; set; }

        [Display(Name = "Apellido")]
        public override  string APELLIDO { get; set; }

        [Display(Name = "Direccion")]
        public override  string DIRECCION { get; set; }

        [Display(Name = "Telefono")]
        public override  string TELEFONO { get; set; }

        [Display(Name = "Email")]
        public override  string EMAIL { get; set; }

        [Display(Name = "Usuario")]
        public string USUARIO { get; set; }

        [Display(Name = "Contraseña")]
        public  string Pwd { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        public override  DateTime FechaNacimiento { get; set; }

        [Display(Name = "Estado civil")]
        public override  int EstadoCivil { get; set; }

        public int Perfil { get; set; }

        [Display(Name = "Nombre Completo")]
        public string NombreCompeto
        {
            get
            {
                return NOMBRE + " " + APELLIDO;
            }
        }
        DateTime _fechaActual; 
        public int Edad 
        {
            get
            {
                _fechaActual = DateTime.Now;
                TimeSpan dif =_fechaActual - FechaNacimiento;
                return dif.Days / 365;               
            } 
        }
    }
}
