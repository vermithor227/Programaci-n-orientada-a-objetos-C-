public class Aprendiz : Persona
{
    private string _numeroFicha;
    private string _programaFormacion;

    public string NumeroFicha
    {
        get { return _numeroFicha; }
        set { _numeroFicha = value; }
    }

    public string ProgramaFormacion
    {
        get { return _programaFormacion; }
        set { _programaFormacion = value; }
    }

    public Aprendiz(string nombres, string apellidos, string documento,
                    string numeroFicha, string programaFormacion)
        : base(nombres, apellidos, documento)
    {
        _numeroFicha = numeroFicha;
        _programaFormacion = programaFormacion;
    }

    public override string Presentarse()
    {
        return $"Hola, soy {Nombres} y estoy estudiando {ProgramaFormacion} ficha:{NumeroFicha}.";
    }
}