using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Producto
    {
        public int Id_producto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion_pro { get; set; }
        public Marca Omarca { get; set; }
        public Categoria Ocategoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Ruta_imagen { get; set; }
        public string Nombre_imagen { get; set; }
        public bool Activo { get; set; }

    }
}
