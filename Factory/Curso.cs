using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Curso
    {
        public int Id { get; set; }
        public List <Categoria> Categorias { get; set; }

        [Display(Name = "Curso")]
        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }
        public int Categoria { get; set; }
        public decimal Valor { get; set; }
        public int Duracion { get; set; }
        public List <UnidadTiempo> UnidadTiempos { get; set; }

        [Display(Name = "Unida de tiempo")]
        public int UnidadTiempo { get; set; }

        [Display(Name = "Total pagar")]
        public decimal ValorTotal
        {
            get
            {
                return Valor * Duracion ; 
            }
        }
        public Categoria Category
        {
            get
            {
                return Categorias.Find(x => x.Id == Categoria);
            }
        }
        public UnidadTiempo Tiempo
        {
            get
            {
                return UnidadTiempos.Find(x => x.Id == UnidadTiempo);
            }
        }
    }
}
