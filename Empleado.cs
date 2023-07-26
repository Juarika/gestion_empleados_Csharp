// Id (entero), Nombre (cadena de caracteres), Edad (entero), Salario (decimal) y Departamento (cadena de caracteres).

public class Empleado 
{
    public long Id { get; set;}
    public string? Nombre { get; set;}
    public int? Edad { get; set;}
    public float? Salario { get; set;}
    public string? Departamento { get; set;}

    public Empleado(long id, string? nombre, int? edad, float? salario, string? departamento)
    {
        Id = id;
        Nombre = nombre;
        Edad = edad;
        Salario = salario;
        Departamento = departamento;
    }
} 