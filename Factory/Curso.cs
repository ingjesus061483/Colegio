using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Categoria { get; set; }
        public decimal Valor { get; set; }
        public int Duracion { get; set; }
        public int UnidadTiempo { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return Valor * Duracion ; 
            }
        }
    }
}
