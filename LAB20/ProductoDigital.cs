namespace LAB20;

public class ProductoDigital : Producto
{
    public double TamanoMB { get; set; }

    public ProductoDigital(string codigo, string nombre, double precio, double tamanoMB)
        : base(codigo, nombre, precio)
    {
        TamanoMB = tamanoMB;
    }

    public override string Describir()
    {
        return $"{Nombre} - Precio: {Precio} - Tamaño: {TamanoMB} MB";
    }
}