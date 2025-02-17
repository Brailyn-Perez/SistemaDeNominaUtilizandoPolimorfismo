class DocentePorHora : Empleado
{
    public int HorasTrabajadas { get; set; }
    private const decimal TarifaPorHora = 800;

    public DocentePorHora(string nombre, int horasTrabajadas)
        : base(nombre, 0) 
    {
        HorasTrabajadas = horasTrabajadas;
    }

    public override decimal CalcularSalario()
    {
        return HorasTrabajadas * TarifaPorHora;
    }
}