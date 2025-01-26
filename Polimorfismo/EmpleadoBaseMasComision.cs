
namespace Polimorfismo
{
    internal class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        private decimal _salarioBase;

        public EmpleadoBaseMasComision(string nombre, string apellido,
        string nss, decimal ventas, decimal tarifa, decimal salario): base(nombre, apellido, nss, ventas, tarifa)
        {
            SalarioBase = salario; // valida el salario base a través de una propiedad
        }

        public decimal SalarioBase
        {
            get
            {
                return _salarioBase;
            }
            set
            {
                _salarioBase = (value >= 0) ? value : 0;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}; {2}: {3:C}",
            "salario base +", base.ToString(), "salario base", SalarioBase);
        }
        public override decimal Ingresos()
        {
            return SalarioBase + base.Ingresos();
        }
    }
}
