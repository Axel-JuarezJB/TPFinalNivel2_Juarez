using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [DisplayName("Categoria")]
        public Categorias DescripcionCategorias { get; set; }
        [DisplayName("Marca")]
        public Marcas DescripcionMarcas { get; set; }
        public string ImagenURL { get; set; }
        public decimal Precio { get; set; }
    }
}
