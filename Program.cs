// * ENTORNO Y MAPA MENTAL:

// Practica guiada #1 (Tu primer objeto)
var m = new Mascota("Misu", 3);
m.Presentarce();

// Reto #1 (Un metodo que devuelve valor)
Console.WriteLine(new Saludo().Decir("Sebastian"));

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



// * CLASES Y OBJETOS:

// Practica guiada #2 (La clase Libro con dos constructores)
var l1 = new Libro("Cien años de soledad", "García Márquez");
var l2 = new Libro("El coronel no tiene quien le escriba");
l1.Prestar();
Console.WriteLine(l1.Descripcion());
Console.WriteLine(l2.Descripcion());

// Reto #2 (Rectángulo)
var r = new Rectangulo(3, 4);
Console.WriteLine(r.Area());       // 12
Console.WriteLine(r.Perimetro());  // 14

// Reto #3 (Copiar un objeto, no la referencia)
var a = new Punto(1, 2);
var b = a;
var c = a.Clonar();
a.X = 99;
Console.WriteLine($"{b.X} {c.X}");   // 99 1



// * ENCAPSULAMIENTO Y PROPIEDADES:

// Practica guiada #3 (Cuenta bancaria protegida)
var cuenta = new CuentaBancaria { Titular = "  Laura Gómez  " };
cuenta.Depositar(500_000m);
bool ok = cuenta.Retirar(700_000m);
Console.WriteLine($"{cuenta.Titular}|{cuenta.Saldo}|{ok}");
cuenta.Retirar(200_000m);
Console.WriteLine(cuenta.Saldo);

// Reto #4 (Temperatura con rango válido)
var t = new Temperatura { Celsius = 100 };
Console.WriteLine(t.Fahrenheit);   // 212

// Reto #5 (Objeto inmutable con required e init)
var u = new Usuario { Email = "a@b.co" };
Console.WriteLine($"{u.Email} {u.Rol}");   // a@b.co invitado



// * HERENCIA:

// Practica guiada #4 (Jerarquía de vehículos)

// Reto #6 (Clase sellada)

// reto #7 (Constructor con base(...) explícito)

// (Ejemplo de Aprendices)

Persona persona = new Persona("Yared", "Acosta", "3314619");
Aprendiz aprendiz = new Aprendiz("Sebastián", "Lamprea", "3341691",
                                 "3314619", "Análisis y Desarrollo de Software");

Console.WriteLine(persona.Presentarse());
Console.WriteLine(aprendiz.Presentarse());
