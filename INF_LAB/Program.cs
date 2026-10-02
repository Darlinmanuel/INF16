namespace INF_LAB;

public class Program
{
    static void Main()
    {
        Estudiante estudiante = new Estudiante("Darlin", 21, "100740039");

        Console.WriteLine($"Nombre: {estudiante.Nombre}\nEdad: {estudiante.Edad}\nMatricula: {estudiante.Matricula}");
    }
}
