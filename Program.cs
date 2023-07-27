// Id (entero), Nombre (cadena de caracteres), Edad (entero), Salario (decimal) y Departamento (cadena de caracteres).

using System;
using System.Collections.Generic;


namespace gestión_empleados
{

    class Program 
    {
        static Dictionary<long, Empleado> empleados = new();

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
                    case 2:
                        MostrarEmpleado();
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
            string? nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el numero de identificacion");
            if (long.TryParse(Console.ReadLine(), out long id)) 
            {    
                Console.WriteLine("Ingresa la edad:");
                if (int.TryParse(Console.ReadLine(), out int edad)) 
                {
                    Console.WriteLine("Ingresa el salario:");
                    if (float.TryParse(Console.ReadLine(), out float salario))
                    {
                        Console.WriteLine("Ingresa el departamento");
                        string? departamento = Console.ReadLine();

                        // Crear nuevo empleado
                        var empleado = new Empleado(nombre: nombre ?? "NN", edad: edad, salario: salario, departamento: departamento ?? "NN", id: id);

                        // Añadir al empleado en diccionario de empleados
                        empleados.Add(key: id, value: empleado);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡Empleado agregado con éxito!");
                        Console.ResetColor();
                    } 
                }
            }
        }

        static void MostrarEmpleado() {

        }

    }
}
