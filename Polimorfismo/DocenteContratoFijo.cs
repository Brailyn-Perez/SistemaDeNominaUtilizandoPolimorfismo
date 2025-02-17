

class DocenteContratoFijo : Empleado
{
    public bool MetaAlcanzada { get; set; }

    public DocenteContratoFijo(string nombre, decimal salarioBase, bool metaAlcanzada)
        : base(nombre, salarioBase)
    {
        MetaAlcanzada = metaAlcanzada;
    }

    public override decimal CalcularSalario()
    {
        return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
    }
}