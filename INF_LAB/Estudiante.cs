namespace INF_LAB;
public class Estudiante : Persona
{

    public string Matricula {  get; set; }

    public Estudiante(string nombre,int edad,string matricula) : base (nombre,edad)    
    {

    Matricula = matricula;

    }
}