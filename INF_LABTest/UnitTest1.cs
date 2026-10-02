using INF_LAB;

namespace INF_LABTest
{
    public class EstudianteTests
    {
        [Fact]
        public void Valores_Correcto()
        {
            Estudiante estudiante = new Estudiante("Darlin", 21, "100740039");

            Assert.Equal("Darlin", estudiante.Nombre);
            Assert.Equal(21, estudiante.Edad);
            Assert.Equal("100740039", estudiante.Matricula);
         
        }
    }
}
