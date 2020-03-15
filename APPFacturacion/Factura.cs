using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPFacturacion
{
    class Factura
    {
        public int idFactura;
        private int idCliente;
        public string fecha;
        public double totalFactura = 0;
        public List<Cliente> listaClientes = new List<Cliente>();
        public List<Producto> listaProductos = new List<Producto>();

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

    }
}
