using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Detalle_venta
    {
        public int Id_detalleventa { get; set; }
        public Venta Id_venta { get; set; }
        public Producto Id_producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

    }
}
