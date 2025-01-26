
namespace Polimorfismo
{
    public abstract class Empleado
    {
        private string _primerNombre;
        private string _apellidoPaterno;
        private string _numeroSeguroSocial;

        protected Empleado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial)
        {
            _primerNombre = primerNombre;
            _apellidoPaterno = apellidoPaterno;
            _numeroSeguroSocial = numeroSeguroSocial;
        }

        public string PrimerNombre
        {
            get
            {
                return _primerNombre;
            }
        }
        public string ApellidoPaterno
        {
            get 
            {
                return _apellidoPaterno;
            }
        }
        public string NumeroSeguroSocial
        {
            get
            {
                return _numeroSeguroSocial;
            }
        }
        public override string ToString() 
        {
            return string.Format(
                $"nombre: {_primerNombre}\n" +
                $"Apellido: {_apellidoPaterno}\n" +
                $"numero de seguro social: {_numeroSeguroSocial}\n"
                );       
        }
        public abstract decimal Ingresos();
    }

}
