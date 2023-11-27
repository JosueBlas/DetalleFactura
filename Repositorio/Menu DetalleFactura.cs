using System;
using System.Collections.Generic;
using System.Linq;
namespace DetalleFactura

public class DetalleFactura
{
    public static void SubMenu()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("- Submenú DetalleFactura -");
            Console.WriteLine("1. Crear");
            Console.WriteLine("2. Actualizar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Salir");

            Console.Write("Ingrese la opción deseada: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
            case "1":
                CrearDetalleFactura()
                break;
            case "2":
                ActualizarDetalleFactura()
                    break,
            case "3":
                EliminarDetalleFactura()
                    break,
            case "4":
                salir = true;
                break,
            default:
                Console.WriteLine("Opción Invalida vuelva a intentarlo")
                break;
            }

            Console.WriteLine();
        }
    }

    public static void CrearDetallesFactura()
    {
        Console.WriteLine("Ingrese los detalles de la nueva factura ");
    }
    public static void ActualizarEmpleado()
    {
        Console.WriteLine("Ingrese el ID del DetalleFactura a actualizar...");
    }
    public static void EliminarEmpleado()
    {
        Console.WriteLine("Ingrese el ID del DetalleFactura a eliminar...");
    }
}
