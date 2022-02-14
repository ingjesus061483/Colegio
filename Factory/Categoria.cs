using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public  class Categoria
    {
        public int Id { get; set; }
        
        [Display(Name ="Categoria")]
        public string Nombre { get; set; }
    }
}
