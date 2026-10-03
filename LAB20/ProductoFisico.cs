namespace LAB20;

public class ProductoFisico : Producto
{
    public double Peso { get; set; }

    public ProductoFisico(string codigo, string nombre, double precio, double peso)
        : base(codigo, nombre, precio)
    {
        Peso = peso;
    }

    public override string Describir()
    {
        return $"{Nombre} - Precio: {Precio} - Peso: {Peso} kg";
    }
}