namespace INF530_LAB_Tests;

public class Empleado_Tests
{
    [Fact]
    public void CalcularPago_DeberiaMultiplicarHorasPorTarifa()
    {
        EmpleadoPorHora empleado = new EmpleadoPorHora("Darlin", 8, 150);

        double resultado = empleado.CalcularPago();

        Assert.Equal(1200, resultado);
    }
}