using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
public     class TipoNovedad
    {
       public int Id { get; set; } 

        [Display(Name = "Tipo de novedad")]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}
