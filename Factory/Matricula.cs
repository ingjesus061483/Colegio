using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Matricula
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int Curso { get; set; }
        public int Jornada { get; set; }
        public int Estudiante { get; set; }
        public decimal Valor { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafin { get; set; }
        public int EstadoMatricula { get; set; }
        public string Descripcion { get; set; }
    }
}
