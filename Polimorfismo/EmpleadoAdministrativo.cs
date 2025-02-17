

class EmpleadoAdministrativo : Empleado
{
    public bool MetaAlcanzada { get; set; }

    public EmpleadoAdministrativo(string nombre, decimal salarioBase, bool metaAlcanzada)
        : base(nombre, salarioBase)
    {
        MetaAlcanzada = metaAlcanzada;
    }

    public override decimal CalcularSalario()
    {
        return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
    }
}
