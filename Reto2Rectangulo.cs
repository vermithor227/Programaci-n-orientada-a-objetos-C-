class Rectangulo
{
	private double ancho;
	private double largo;

	public Rectangulo(double ancho, double largo)
	{
		this.ancho = ancho;
		this.largo = largo;
	}

	public double Area() => ancho * largo;

	public double Perimetro() => 2 * (ancho * largo);
}