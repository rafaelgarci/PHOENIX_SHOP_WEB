using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Venta
    {
        public int Id_venta { get; set; }
        public Cliente Id_cliente { get; set; }
        public int Total_producto { get; set; }
        public decimal Monto_total { get; set; }
        public string Contacto { get; set; }
        public string Id_distrito { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Id_transaccion { get; set; }
        
    }
}
