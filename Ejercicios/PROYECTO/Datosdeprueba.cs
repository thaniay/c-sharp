using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {
        Console.Clear();
        Producto p1 = new Producto (1,"                 Capuccino            ",40);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto (2,"                 Expreso              ",35);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto (3,"                 Mochaccino           ",50);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto (4,"                 Granita              ",25);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto (5,"                 Te Frio              ",20);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto (6,"                 Tiramisu             ",70);
        ListadeProductos.Add(p6);

        Producto p7 = new Producto (7,"                 Flan de cafe         ",62);
        ListadeProductos.Add(p7);

        Producto p8 = new Producto (8,"                 Brownie              ",55);
        ListadeProductos.Add(p8);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "                  Thania        ","      77777");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "                  Yorely        ","      99999");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "                  Norma         ","      88888");
        ListadeClientes.Add(c3);

        Cliente c4 = new Cliente(4, "                  Magdalena     ","      77777");
        ListadeClientes.Add(c4);

        Cliente c5 = new Cliente(5, "                  Dimas         ","      66666");
        ListadeClientes.Add(c5);

        Cliente c6 = new Cliente(6, "                  Jose          ","      55555");
        ListadeClientes.Add(c6);
    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "          Bradin Moreno         ", "     B001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "          Jose Andero           ", "     B002");
        ListadeVendedores.Add(v2);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.Clear();
        Console.WriteLine("=====================================================================");
        Console.WriteLine("                      Lista de Productos");
        Console.WriteLine("=====================================================================");
        Console.WriteLine("Cod|                   Nombre              |      Precio");
        Console.WriteLine("=====================================================================");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }
        Console.WriteLine("=====================================================================");
        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("=======================================================================");
        Console.WriteLine("                            Lista de Clientes");
        Console.WriteLine("=======================================================================");
        Console.WriteLine("Cod|                 Nombre          |      Telefono");
        Console.WriteLine("=======================================================================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }
        Console.WriteLine("=======================================================================");
        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        
        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("=====================================================================");
        Console.WriteLine("                      Lista de Vendedores");
        Console.WriteLine("=====================================================================");
        Console.WriteLine("Cod|              Nombre             | Codigo Vendedor");
        Console.WriteLine("=====================================================================");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }
        Console.WriteLine("=====================================================================");
        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        Console.ReadLine();
    }

    public void CrearOrden()
    {   
        Console.Clear();
        Console.WriteLine("=====================================================================");
        Console.WriteLine("                          Creando Orden");
        Console.WriteLine("======================================================================");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("SubTotal de la orden es de: " + nuevaOrden.SubTotal);
        Console.WriteLine("Impuesto de la orden es de: " + nuevaOrden.OrdenImpuesto);
        Console.WriteLine("Total de la orden es de: " + nuevaOrden.Total);
        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("===============================================================================");
        Console.WriteLine("                                 FACTURA ");
        Console.WriteLine("===============================================================================");
        Console.WriteLine("");  
        Console.WriteLine("Cod|       Fecha         |     SubTotal     |   Impuesto    |   Total  ");
        Console.WriteLine("===============================================================================");
        Console.WriteLine();  

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + "  |        "+ orden.SubTotal + "        |   " + orden.OrdenImpuesto + "        |   "+ orden.Total);
            Console.WriteLine("===============================================================================");
            Console.WriteLine("                 Cliente              |           Vendedor");
            Console.WriteLine("===============================================================================");
            Console.WriteLine(orden.Cliente.Nombre + "      | " + orden.Vendedor.Nombre);

            Console.WriteLine("===============================================================================");
            Console.WriteLine("                         Descripcion de la orden    ");
            Console.WriteLine("===============================================================================");
            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine( detalle.Producto.Descripcion + " |           " + detalle.Cantidad + " |              " + detalle.Precio);
            }

            Console.WriteLine();
        } 
        Console.WriteLine("===============================================================================");
        Console.Write("Presione la tecla enter para salir.");
        Console.ReadLine();
    }
}