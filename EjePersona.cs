public class Persona
{
    private string _nombres;
    private string _apellidos;
    private string _documento;

    public string Nombres
    {
        get { return _nombres; }
        set { _nombres = value; }
    }

    public string Apellidos
    {
        get { return _apellidos; }
        set { _apellidos = value; }
    }

    public string Documento
    {
        get { return _documento; }
        set { _documento = value; }
    }

    public Persona(string nombres, string apellidos, string documento)
    {
        _nombres = nombres;
        _apellidos = apellidos;
        _documento = documento;
    }


    public virtual string Presentarse()
    {
        return $"Hola, mi nombre es {Nombres} CC.{Documento}.";
    }
}