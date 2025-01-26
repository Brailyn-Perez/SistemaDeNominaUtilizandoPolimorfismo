
namespace Polimorfismo
{
    public class EmpleadoAsalariado : Empleado
    {
        private decimal _salarioSemanal;

        public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salario) 
        : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            _salarioSemanal = salario;
        }

        public override decimal Ingresos()
        {
            return _salarioSemanal;
        }

        public decimal SalarioSemanal
        {
            get
            {
                return _salarioSemanal;
            }
            set
            {
                SalarioSemanal = ((value >= 0) ? value : 0);
            }
        }

        public override string ToString()
        {
            return string.Format("empleado asalariado: {0}\n{1}: {2:C}",
             base.ToString(), "salario semanal", SalarioSemanal);
        }
    }
}
