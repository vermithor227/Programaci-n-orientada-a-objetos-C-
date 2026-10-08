// Para entender el codigo y lo que se hace linea por linea (con los 3 constructores asi aprendo jajajaj)

// Primero: Declaro una clase llamada "Estudiate" 
class Estudiantes
{
	// Segundo: los campos (los tipos de datos que guarda cada objeto)

	private string nombre; // * Tener en cuenta lo siguiente: "private" significa que solo se pueden usar dentro de la clase, y nadie desde afuera puede cambiarlos directamente.
	private int edad;
	private string programa;

	// Terceso: Constructor 1 (el completo). 
	public Estudiantes(string nombre, int edad, string programa) // * Tener en cuenta lo siguiente: Un constructor se llama igual que la clase y no lleva tipo de retorno. Recibe tres datos y los guarda en los campos.
	{
		// "this.nombre" es el campo de la clase, y nombre (sin this) es el parámetro que ingresa o llega.
		// DATO IMPORTANTE: Se usa this para que C# no los confunda, porque se llaman igual. Este es el único constructor que asigna valores.
		this.nombre = nombre; 
		this.edad = edad;
		this.programa = programa;
	}

	// Cuarto: Constructor 2: sin programa.
	// Recibe solo nombre y edad. Después de los : dice this(nombre, edad, "Sin asignar").
	// * Tener en cuenta lo siguiente: que significa "llama al constructor de esta misma clase que recibe tres datos, y pásale estos valores". El programa lo completa con "Sin asignar".
	// DATO IMPORTANTE: Las llaves { } quedan vacías porque el constructor 1 ya hizo todo el trabajo.
	public Estudiantes(string nombre, int edad) : this(nombre, edad, "Sin asignar") { }

	// Quinto: Constructor 3: solo nombre
	// Recibe solo el nombre. Llama al constructor 1 con la edad por defecto 18 y el programa "Sin asignar".
	public Estudiantes(string nombre) : this(nombre, 18, "Sin asignar") { }

	// Esto es un metodo (Realiza lo siguiente):
	// "public" hace que se pueda llamar desde afuera.
	// "string" indica que devuelve un texto.
	// "Presentar" es el nombre. El $"..." es una cadena interpolada.
	public string presentar()
	{
		// lo que va entre { } se reemplaza por el valor de la variable.
		// "return" devuelve ese texto a quien llamó el método.
		return $"{nombre}, {edad} años, programa: {programa}";
	}
}