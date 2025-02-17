using System;
using System.Collections.Generic;

abstract class Empleado
{
    public string Nombre { get; set; }
    public decimal SalarioBase { get; set; }

    public Empleado(string nombre, decimal salarioBase)
    {
        Nombre = nombre;
        SalarioBase = salarioBase;
    }

    public abstract decimal CalcularSalario();
}
