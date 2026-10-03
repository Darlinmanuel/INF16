namespace LAB20;

public class Producto
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Producto(string codigo, string nombre, double precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
    }

    public virtual string Describir()
    {
        return $"{Codigo} - {Nombre} - {Precio}";
    }
}