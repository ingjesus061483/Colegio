using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Jornada
    {
        public int Id { get; set; }

        [Display(Name ="Jornada")]
        public  string Nombre { get; set; }

        
    }
}
