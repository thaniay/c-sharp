﻿using System;

namespace _10_Ordenes
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdePrueba datos = new DatosdePrueba();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("================================================================");
                Console.WriteLine("                  BIENBIENIDOS A LA CAFETERIA ");
                Console.WriteLine("================================================================");
                Console.WriteLine("");
                Console.WriteLine("1 - Menu");
                Console.WriteLine("2 - Crear Orden");
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Lista de Vendedores");
                Console.WriteLine("5 - Lista de Ordenes");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("================================================================");
                Console.WriteLine();
                Console.Write("Elija una opcion : ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;
                    case "2":
                        datos.CrearOrden();
                        break;
                    case "3":
                        datos.ListarClientes();
                        break;
                    case "4":
                        datos.ListarVendedores();
                        break;      
                    case "5":
                        datos.ListarOrdenes();
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0") {
                    Console.WriteLine();
                    Console.Write("Gracias por su visita .... :) ");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}