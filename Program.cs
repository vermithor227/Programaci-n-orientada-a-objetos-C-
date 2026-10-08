
// Practica guiada #1 (Tu primer objeto)
var m = new Mascota("Misu", 3);
m.Presentarce();

// Reto #1 (Un metodo que devuelve valor)
Console.WriteLine(new Saludo().Decir("Sebastian"));

// Practica guiada "2 (La clase Libro con dos constructores)
var l1 = new Libro("Cien años de soledad", "García Márquez");
var l2 = new Libro("El coronel no tiene quien le escriba");
l1.Prestar();
Console.WriteLine(l1.Descripcion());
Console.WriteLine(l2.Descripcion());

// (Ejemplo de 3 constructores trabajado en clase)

// "new" crea un objeto de la clase. Como le pasas 3 argumentos, C# usa el constructor 1. "var" deja que C# deduzca el tipo, que aquí es "Estudiante".
var e1 = new Estudiantes("Sebastián", 20, "ADSO");

// Con 2 argumentos (string e int) usa el constructor 2, y el programa queda como "Sin asignar".
var e2 = new Estudiantes("Ana", 19);

// Con 1 argumento usa el constructor 3, así que la edad queda en 18 y el programa en "Sin asignar".
var e3 = new Estudiantes("Carlos");

// Cada línea llama a "Presentar()" del objeto, que devuelve el texto armado, y "Console.WriteLine" lo imprime en la consola.
Console.WriteLine(e1.presentar());
Console.WriteLine(e2.presentar());
Console.WriteLine(e3.presentar());

// Reto #2 (Rectángulo)

// Reto #3 (Copiar un objeto, no la referencia)
