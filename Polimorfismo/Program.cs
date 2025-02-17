
internal class Program
{
    private static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>
        {
            new DocentePorHora("Carlos", 40),
            new DocenteContratoFijo("María", 50000, true),
            new EmpleadoAdministrativo("Luis", 40000, false)
        };

        foreach (var empleado in empleados)
        {
            Console.WriteLine($"{empleado.Nombre} gana: {empleado.CalcularSalario():C}");
        }
    }
}