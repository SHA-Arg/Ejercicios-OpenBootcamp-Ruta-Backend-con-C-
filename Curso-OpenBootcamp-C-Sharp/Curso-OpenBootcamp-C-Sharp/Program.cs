//Ejercicio 1
using System;

namespace Curso_OpenBootcamp_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Humano quiero conocerlo...");
            Console.WriteLine("Ingrese su nombre porfavor: ");
            Console.WriteLine("==================================");
            string nombre = Console.ReadLine();
            string miNombre = "Sebastian Amaral, un placer conocerte!!";
            Console.WriteLine("Hola " + nombre + ", el mio es " + miNombre);
            Console.WriteLine("==================================");
            //Ejercicio 2
            Console.WriteLine("La hora actual es: " + DateTime.Now);
        }
    }
}
