using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class UnidadTiempo
    {
        public int Id { get; set; }

        [Display(Name = "Unida de tiempo")]
        public string Nombre { get; set; }



    }
}
