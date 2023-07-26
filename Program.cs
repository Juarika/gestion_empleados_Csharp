// Id (entero), Nombre (cadena de caracteres), Edad (entero), Salario (decimal) y Departamento (cadena de caracteres).

using System;
using System.Collections.Generic;

class Program 
{
    static readonly Dictionary<long, Empleado> empleados = new();

    public static Dictionary<long, Empleado> Empleados => empleados;

    static void Main() {
        int opcion;

        do 
        {
            Menu();
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                    Agregar();
                    break;
            }
        } while (opcion != 7);
    }

    static void Menu() {
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Agregar empleado");
        Console.WriteLine("2. Mostrar un empleado");
        Console.WriteLine("3. Listar los empleados");
        Console.WriteLine("4. Salario promedio de la empresa");
        Console.WriteLine("5. Salario promedio de un departamento");
        Console.WriteLine("6. Buscar empleados");
        Console.WriteLine("7. Salir");
    }

    static void Agregar() {
        Console.WriteLine("Ingresa el nombre:");
        Console.WriteLine("Ingresa la edad:");
        Console.WriteLine("Ingresa el salario:");
        Console.WriteLine("Ingresa el departamento");
        Console.WriteLine("");
    }
}
