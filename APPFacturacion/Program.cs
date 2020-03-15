using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPFacturacion
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> listaClientes = new List<Cliente>();
            List<Factura> listaFacturas = new List<Factura>();
            List<Producto> listaProductos = new List<Producto>();



            string seguir = "si";
            int doc;
            string datoModificar;
            int idFactura;


            while (seguir != "no")
            {
                int respuestaInicio;
                Console.WriteLine("Elija una opción");
                Console.WriteLine("(1) para gestion de clientes (2) para gestion de productos (3) para facturación (4) Gestión de reportes (5) Para salir del programa");
                respuestaInicio = int.Parse(Console.ReadLine());

                if (respuestaInicio == 1)
                {
                    //gestion clientes:

                    int rtaCliente;
                    Console.WriteLine("(1) Agregar Cliente (2) Modificar cliente (3) cambiar estado cliente (4) Listar Clientes (5) salir del modulo clientes.");
                    rtaCliente = int.Parse(Console.ReadLine());

                    if (rtaCliente == 1)
                    {
                        //TODO: agregar cliente
                        Cliente cliente = new Cliente();

                        Console.WriteLine("Ingrese el documento del cliente");
                        cliente.documento = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre del cliente");
                        cliente.nombreCliente = Console.ReadLine();
                        Console.WriteLine("Ingrese el telefono");
                        cliente.telefono = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la edad del cliente");
                        cliente.edad = int.Parse(Console.ReadLine());


                        listaClientes.Add(cliente);
                    }
                    else if (rtaCliente == 2)
                    {
                        //TODO: modificar cliente

                        Console.WriteLine("Digite el documento del cliente a modificar");
                        doc = int.Parse(Console.ReadLine());

                        for (int i = 0; i < listaClientes.Count; i++)
                        {
                            if (doc == listaClientes[i].documento && listaClientes[i].estado == 1)
                            {
                                Console.WriteLine("Desea modificar: nombre, edad o telefono");
                                datoModificar = Console.ReadLine();
                                switch (datoModificar)
                                {
                                    case "nombre":
                                        Console.WriteLine("Ingrese el nuevo nombre");
                                        string nomCliente = Console.ReadLine();
                                        listaClientes[i].nombreCliente = nomCliente;
                                        break;
                                    case "edad":
                                        Console.WriteLine("Ingrese la nueva edad");
                                        int edadCliente = int.Parse(Console.ReadLine());
                                        listaClientes[i].edad = edadCliente;
                                        break;
                                    case "telefono":
                                        Console.WriteLine("Ingrese el nuevo telefono");
                                        int telCliente = int.Parse(Console.ReadLine());
                                        listaClientes[i].telefono = telCliente;
                                        break;
                                }
                            }
                        }
                    }
                    else if (rtaCliente == 3)
                    {
                        //TODO: cambiar estado cliente
                        Console.WriteLine("Digite el documento del cliente a modificar el estado");
                        doc = int.Parse(Console.ReadLine());
                        for (int i = 0; i < listaClientes.Count; i++)
                        {


                            if (doc == listaClientes[i].documento)
                            {
                                Console.WriteLine("Estado modificar: (1) para habilitar o (0) para deshabilitar");
                                int estadoModificar = int.Parse(Console.ReadLine());
                                switch (estadoModificar)
                                {
                                    case 1:
                                        listaClientes[i].estado = estadoModificar;
                                        break;
                                    case 0:

                                        listaClientes[i].estado = estadoModificar;
                                        break;

                                }
                            }
                        }

                    }
                    else if (rtaCliente == 4)
                    {
                        //TODO: listar clientes

                        int rtaListar;
                        Console.WriteLine("(1) listar clientes por documento (2) listar todos los clientes.");
                        rtaListar = int.Parse(Console.ReadLine());

                        if (rtaListar == 1)
                        {
                            //listar por documento

                            Console.WriteLine("Ingrese el numero del documento");
                            doc = int.Parse(Console.ReadLine());

                            foreach (var client in listaClientes)
                            {
                                if (client.documento == doc)
                                {
                                    Console.WriteLine("nombre: " + client.NombreCliente
                                   + " documento: " + client.Documento
                                   + " telefono: " + client.Telefono
                                   + " edad: " + client.Edad
                                   + " estado: " + client.Estado);
                                }
                            }
                        }
                        else if (rtaListar == 2)
                        {
                            //listar todos los clientes

                            foreach (Cliente client in listaClientes)
                            {
                                Console.WriteLine("nombre: " + client.NombreCliente
                                        + " documento: " + client.Documento
                                        + " telefono: " + client.Telefono
                                        + " edad: " + client.Edad
                                        + " estado: " + client.Estado);
                            }

                        }
                    }
                }

                else if (respuestaInicio == 2)
                {
                    //gestion productos
                    int rtaProductos;
                    Console.WriteLine("(1) Agregar Producto (2) Modificar estado de Producto (3) Modificar producto (4) listar Producto");
                    rtaProductos = int.Parse(Console.ReadLine());

                    if (rtaProductos == 1)
                    {
                        //Agregar producto
                        Producto producto = new Producto();

                        Console.WriteLine("Ingrese el codigo del producto");
                        producto.idProducto = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre del producto");
                        producto.nombreProducto = Console.ReadLine();
                        Console.WriteLine("Ingrese el valor del producto");
                        producto.valor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el stock del producto");
                        producto.stock = int.Parse(Console.ReadLine());

                        listaProductos.Add(producto);
                    }
                    else if (rtaProductos == 2)
                    {
                        //Modificar estado producto

                        Console.WriteLine("Ingrese el codigo del producto a cambiar de estado");
                        int codModificar = int.Parse(Console.ReadLine());

                        for (int i = 0; i < listaProductos.Count; i++)
                        {
                            if (codModificar == listaProductos[i].idProducto)
                            {
                                Console.WriteLine("(0) para deshabilitar producto, (1) para habilitar");
                                int cambEstadoP = int.Parse(Console.ReadLine());
                                switch (cambEstadoP)
                                {
                                    case 1:
                                        listaProductos[i].estadoProducto = cambEstadoP;
                                        break;
                                    case 0:
                                        listaProductos[i].estadoProducto = cambEstadoP;
                                        break;
                                }
                            }
                        }
                    }

                    else if (rtaProductos == 3)
                    {
                        //Modificar producto
                        Console.WriteLine("Digite el codigo del producto a modificar");
                        doc = int.Parse(Console.ReadLine());

                        for (int i = 0; i < listaProductos.Count; i++)
                        {
                            if (doc == listaProductos[i].IdProducto)
                            {

                                Console.WriteLine("Desea modificar: nombre, precio o stock");
                                datoModificar = Console.ReadLine();
                                switch (datoModificar)
                                {
                                    case "nombre":
                                        Console.WriteLine("Ingrese el nuevo nombre del producto");
                                        string nomProducto = Console.ReadLine();
                                        listaProductos[i].nombreProducto = nomProducto;
                                        break;
                                    case "precio":
                                        Console.WriteLine("Ingrese la nuevo precio");
                                        int precioProducto = int.Parse(Console.ReadLine());
                                        listaProductos[i].valor = precioProducto;
                                        break;
                                    case "stock":
                                        Console.WriteLine("Ingrese el nuevo stock");
                                        int stockproduct = int.Parse(Console.ReadLine());
                                        listaProductos[i].stock = stockproduct;
                                        break;
                                }
                            }
                        }
                    }
                    else if (rtaProductos == 4)
                    {
                        //Listar producto

                        int rtaListar;
                        Console.WriteLine("(1) listar producto por id (2) listar todos los productos.");
                        rtaListar = int.Parse(Console.ReadLine());

                        if (rtaListar == 1)
                        {
                            //listar por id producto

                            Console.WriteLine("Ingrese el numero del id");
                            doc = int.Parse(Console.ReadLine());

                            foreach (var product in listaProductos)
                            {
                                if (product.idProducto == doc)
                                {
                                    Console.WriteLine("codigo producto: " + product.IdProducto
                                   + " nombre: " + product.NombreProducto
                                   + " valor: " + product.Valor
                                   + " stock: " + product.Stock
                                   + " estado: " + product.EstadoProducto);
                                }
                            }
                        }
                        else if (rtaListar == 2)
                        {
                            //listar todos los productos

                            foreach (Producto product in listaProductos)
                            {
                                Console.WriteLine("codigo producto: " + product.IdProducto
                                   + " nombre: " + product.NombreProducto
                                   + " valor: " + product.Valor
                                   + " stock: " + product.Stock
                                   + " estado: " + product.EstadoProducto);
                            }

                        }
                    }
                }
                else if (respuestaInicio == 3)
                {
                    //facturar

                    int rtaFacturar;
                    Console.WriteLine("(1) Agregar Factura (2) listar todas las facturas");
                    rtaFacturar = int.Parse(Console.ReadLine());

                    idFactura = listaFacturas.Count + 1;

                    if (rtaFacturar == 1)
                    {
                        //Agregar factura
                        Factura factura = new Factura();

                        Console.WriteLine("Ingrese el documento del cliente");
                        int idCliente = int.Parse(Console.ReadLine());
                        for (int i = 0; i < listaClientes.Count; i++)
                            if (idCliente == listaClientes[i].documento)
                        {
                            foreach (var client in listaClientes)
                        {
                            Console.WriteLine("------------Encabezado de factura--------");
                            Console.WriteLine(" Cedula "+client.Documento
                                +" Nombre cliente "+client.NombreCliente
                                +" Telefono "+client.Telefono+" Edad "+client.Edad);
                        }
                        }
                        Console.WriteLine("Ingrese el codigo del producto comprado");
                        int CodProd = int.Parse(Console.ReadLine());
                        for (int i = 0; i < listaProductos.Count; i++)
                            if (CodProd == listaProductos[i].idProducto)
                            {
                                foreach (var produc in listaProductos)
                                {
                                    Console.WriteLine("------------Productos Comprados--------");
                                    Console.WriteLine("Codigo Producto "+produc.IdProducto
                                        +" Nombre Producto "+produc.NombreProducto
                                        +" Valor Producto "+produc.Valor);
                                }
                            }

                    }
                    else if (rtaFacturar == 2)
                    {
                        //listar todas las facturas
                        Console.WriteLine("(1) para listar por codigo factura (2) todas las facturas");
                        int rta = int.Parse(Console.ReadLine());
                        if (rta == 1)
                        {
                            Console.WriteLine("Ingrese el numero de la factura");
                            doc = int.Parse(Console.ReadLine());

                            foreach (var fact in listaFacturas)
                            {
                                if (fact.idFactura == doc)
                                {
                                    Console.WriteLine("número factura: " + fact.idFactura
                                   + " cliente: " + fact.IdCliente);

                                }
                            }
                        }

                        else if (rta == 2)
                        {
                            //listar todos los productos

                            foreach (var fact in listaFacturas)
                            {
                                Console.WriteLine("número factura: " + fact.idFactura
                                  + " cliente: " + fact.IdCliente);
                            }

                        }

                    }
                }

                else if (respuestaInicio == 4)
                {
                    //reportes
                    int rtaReportes;
                    Console.WriteLine("(1) Clientes > 30 años (2) Producto con Stock<2 (3) Facturas>200.000$.");
                    rtaReportes = int.Parse(Console.ReadLine());

                    if (rtaReportes == 1)
                    {
                        //Clientes > 30
                    }
                    else if (rtaReportes == 2)
                    {
                        //Producto Stock<2
                    }
                    else if (rtaReportes == 3)
                    {
                        //Facturas>200.000
                    }
                }

                Console.WriteLine("desea volver al menú principal para cambiar de módulo?");
                string rtaSeguir = Console.ReadLine();

                if (rtaSeguir.Equals("no"))
                {
                    seguir = "no";
                }
            }
        }
    }

}
