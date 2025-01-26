
namespace Polimorfismo
{
    internal class EmpleadoPorHoras : Empleado
    {
        private decimal _sueldo;
        private decimal _horas;

        public EmpleadoPorHoras(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal sueldoHoras, decimal horasTrabajadas) 
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            _sueldo = sueldoHoras;
            _horas = horasTrabajadas;
        }

        public decimal Sueldo
        {
            get
            {
                return _sueldo;
            }
            set
            {
                _sueldo = ((value >= 0) ? value : 0);
            }
        }
        public decimal Horas
        {
            get
            {
                return _horas;
            }
            set
            {
                _horas = ((value >= 0) && (value <= 168)) ? value : 0;
            }
        }

        public override decimal Ingresos()
        {
            if (_horas <= 40)
            {
                return _horas * _sueldo;
            }
            else
            {
                return (40 * _sueldo) + ((_horas - 40) * _sueldo * 1.5M);
            }
        }
        public override string ToString()
        {
            return string.Format(
            "empleado por horas: {0}\n{1}: {2:C}; {3}: {4:F2}",
            base.ToString(), "sueldo por horas", _sueldo, "horas trabajadas", _horas);

        }
    }
}
