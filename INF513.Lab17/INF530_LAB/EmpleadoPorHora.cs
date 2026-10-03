using INF530_LAB;

public class EmpleadoPorHora : Empleado
{
    public double Horas { get; set; }
    public double Tarifa { get; set; }

    public EmpleadoPorHora(string nombre, double horas, double tarifa)
        : base(nombre)
    {
        Horas = horas;
        Tarifa = tarifa;
    }

    public override double CalcularPago()
    {
        return Horas * Tarifa;
    }
}