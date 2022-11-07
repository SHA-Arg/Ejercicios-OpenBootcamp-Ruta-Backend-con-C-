/* Ejercicio 1
Variables Escribe un programa que reciba datos de una persona y
genera un mensaje, usa una variable para cada dato y otra para 
el mensaje. Ej: nombre, apellido, edad, sabe programar, etc. */

Console.WriteLine("Hola Humano quiero conocerlo...");
Console.WriteLine("Ingrese su nombre porfavor: ");
var nombre = Console.ReadLine();
Console.WriteLine("Ahora su apellido: ");
var apellido = Console.ReadLine();
Console.WriteLine("Ingrese su edad: ");
var edad = Console.ReadLine();
Console.WriteLine("¿Sabe programar? (si/no): ");
var sabeProgramar = Console.ReadLine();
var mensaje = "Hola " + nombre + " " + apellido + ", tu edad es " + edad + " y " + (sabeProgramar == "si" ? "sabes programar" : "no sabes programar");
Console.WriteLine(mensaje);

/* Ejercicio 2 

Tipos: Usando los tipos de variables más adecuados, describe los objetos siguientes:

Coche: puertas, ruedas, marca, ITV vigente

Mesa: peso, largo, material, color

Nota: puedes escribir estos datos por consola si prefieres verlos.
La idea del ejercicio es almacenar los datos en los tipos más adecuados
 */

//Variables para coche
int puertas = 4;
int ruedas = 4;
string marca = "Seat";
bool itvVigente = true;

//Variables para mesa
float peso = 10.5f;
float largo = 1.5f;
string material = "Madera";
string color = "Marron";

/*Ejercicio 3

Operadores: Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

Nota: puedes escribir estos datos por consola si prefieres verlos.
La idea del ejercicio es almacenar los datos en los tipos más adecuados.
 
 */

//Un número es mayor o igual a 18

bool esMayorOIgual = numero >= 18;

//Un char es ‘a’

bool caracter = char == 'a';

//Se cumplen dos conciones a la vez (ambas verdaderas)

bool seCumplenAmbas = condicion1 && condicion2;

//Se cumplen una de las dos condiciones a la vez (una true y otra false)

bool seCumpleUna = condicion3 || condicion4;




