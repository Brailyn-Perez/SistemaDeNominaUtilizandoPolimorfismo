
namespace Polimorfismo
{
    internal class EmpleadoPorComision : Empleado
    {
        private decimal _tarifaComision;
        private decimal _ventasBrutas;

        public EmpleadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventas, decimal tarifa) 
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            _tarifaComision = tarifa;
            _ventasBrutas = ventas;
        }

        public override decimal Ingresos()
        {
            return _tarifaComision * _ventasBrutas;
        }

        public decimal TarifaComision
        {
            get
            {
                return _tarifaComision;
            }
            set
            {
                _tarifaComision = (value > 0 && value < 1) ? value : 0;
            }
        }

        public decimal VentasBrutas
        {
            get
            {
                return _ventasBrutas;
            }
            set
            {
                _ventasBrutas = (value >= 0) ? value : 0;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}", 
             "empleado por comisión", base.ToString(),
            "ventas brutas", VentasBrutas, "tarifa de comisión", TarifaComision);

        }
    }
}
