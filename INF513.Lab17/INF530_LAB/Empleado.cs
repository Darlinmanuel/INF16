namespace INF530_LAB;

public class Empleado
{
    public string Nombre { get; set; }

    public Empleado(string nombre)
    {
        Nombre = nombre;
    }

    public virtual double CalcularPago()
    {
        return 0;
    }
}