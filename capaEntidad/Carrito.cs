using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Carrito
    {
        public int Id_carrito { get; set; }
        public Cliente Id_cliente { get; set; }
        public Producto Id_producto { get; set; }
        public int Cantidad { get; set; }

    }
}
