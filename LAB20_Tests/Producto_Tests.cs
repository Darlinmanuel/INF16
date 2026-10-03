using Xunit;
using LAB20;

namespace LAB20_Tests;

public class UnitTest1
{
    [Fact]
    public void Productos_FuncionanCorrectamente()
    {
        ProductoFisico fisico = new ProductoFisico("P01", "Laptop", 30000, 2.5);

        Assert.Equal("P01", fisico.Codigo);
        Assert.Equal("Laptop", fisico.Nombre);
        Assert.Equal(30000, fisico.Precio);
        Assert.Equal(2.5, fisico.Peso);
        Assert.Contains("Laptop", fisico.Describir());


        ProductoDigital digital = new ProductoDigital("P02", "Video", 500, 700);

        Assert.Equal("P02", digital.Codigo);
        Assert.Equal("Video", digital.Nombre);
        Assert.Equal(500, digital.Precio);
        Assert.Equal(700, digital.TamanoMB);
        Assert.Contains("Video", digital.Describir());
    }
}