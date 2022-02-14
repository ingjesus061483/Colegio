using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Novedad
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public List <Matricula > Matriculas { get; set; }
        public List <TipoNovedad > TipoNovedads { get; set; }
        [Display(Name = "Fecha novedad")]
        public DateTime Fecha { get; set; }

        [Display(Name = "Tipo de novedad")]
        public int TipoNovedad { get; set; }

        public string Descripcion { get; set; }
        public Matricula matricula 
        {
            get
            {
                return Matriculas.Find(x => x.Id == Matricula);
            }
        }
        public TipoNovedad tipoNovedad
        {
            get
            {
                return TipoNovedads.Find(x => x.Id == TipoNovedad);
            }
        }
    }
}
