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
                CrearEmpleado()
                break;
            case "2":
                ActualizarEmpleado()
                    break,
            case "3":
                EliminarEmpleado()
                    break,
            case "4":
                salir = true;
                break,
            default:
                Console.WriteLine("Opción Incorrecta, vuelva a intentarlo")
                break;
            }

            Console.WriteLine();
        }
    }

    public static void CrearEmpleado()
    {
        Console.WriteLine("Ingrese los detalles de la nueva factura ");
    }
    public static void ActualizarEmpleado()
    {
        Console.WriteLine("Ingrese el ID del empleado a actualizar...");
    }
    public static void EliminarEmpleado()
    {
        Console.WriteLine("Ingrese el ID del empleado a eliminar...");
    }
}