using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Matricula
    {
        public int Id { get; set; }
        public int Curso { get; set; }
        public int Jornada { get; set; }
        public int Estudiante { get; set; }
        public int EstadoMatricula { get; set; }
        public string Descripcion { get; set; }
        [Display(Name = "Valor matricula")]
        public decimal Valor { get; set; }

        [Display(Name = "Fecha de inicio")]
        public DateTime Fechainicio { get; set; }


        public List <EstadoMatricula> EstadoMatriculas { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List <Jornada >jornadas { get; set; }
        public EstadoMatricula estadoMatricula
        {
            get
            {
                return EstadoMatriculas.Find(x => x.Id == EstadoMatricula);
            }          
        }

        public Usuario Usuario
        {
            get
            {
                return Usuarios.Find(x => x.ID == Estudiante);
            }
        }
        public string Codigo
        {
            get
            {
                return DateTime.Now.Year.ToString() + Usuario.IDENTIFICACION.Substring(Usuario.IDENTIFICACION.Length-4);
            }
        }
        public List<Curso> Cursos { get; set; }
        public Curso curso
        {
            get
            {
                return Cursos.Find(x => x.Id == Curso);
            }
        }
        public Jornada jornada 
        {
            get
            {
                return jornadas.Find(x => x.Id == Jornada);
            } }

        DateTime _fechaFin;
        [Display(Name = "Fecha fin")]
        public DateTime Fechafin
        {
            get
            {
                int duracion = curso.Duracion;
                switch (curso.UnidadTiempo)
                {
                    case 1:
                        {
                            _fechaFin = Fechainicio.AddDays(duracion);
                            break;
                        }
                    case 2:
                        {
                            _fechaFin = Fechainicio.AddMonths(duracion);
                            break;
                        }
                    case 3:
                        {
                            _fechaFin = Fechainicio.AddYears(duracion);
                            break;
                        }
                }
                return _fechaFin;
            }
        }
    }
}
