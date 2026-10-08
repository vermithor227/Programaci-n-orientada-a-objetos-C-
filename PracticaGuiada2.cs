class Libro
{
    private string titulo;
    private string autor;
    private bool prestado;

    public Libro(string titulo, string autor)
    {
        this.titulo = titulo;
        this.autor = autor;
    }

    public Libro(string titulo) : this(titulo, "Anónimo") { }

    public void Prestar() => prestado = true;

    public string Descripcion()
    {
        var estado = prestado ? "prestado" : "disponible";
        return $"{titulo} - {autor} [{estado}]";
    }
}