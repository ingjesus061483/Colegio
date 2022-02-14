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

        [Display(Name = "Fecha novedad")]
        public DateTime fecha { get; set; }

        [Display(Name = "Tipo de novedad")]
        public int TipoNovedad { get; set; }

        public string Descripcion { get; set; }
    }
}
