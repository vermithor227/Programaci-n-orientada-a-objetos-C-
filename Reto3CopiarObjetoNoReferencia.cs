class Punto(int x, int y)
{
	public int X = x;
	public int Y = y;

	public Punto Clonar() => new Punto(X, Y);
}