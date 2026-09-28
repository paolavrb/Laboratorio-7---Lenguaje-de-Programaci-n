using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Refactorizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                MostrarMenu();

                int op = LeerEntero("\nElige una opcion: ");

                switch (op)
                {
                    case 1:
                        CalcularCuadrado();
                        break;
                    case 2:
                        CalcularRectangulo();
                        break;
                    case 3:
                        CalcularTriangulo();
                        break;
                    case 4:
                        CalcularCirculo();
                        break;
                    case 5:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("\nOpcion invalida");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresiona una tecla para volver al menu");
                    Console.ReadKey();
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("\n*********************");
            Console.WriteLine("Calculadora de areas");
            Console.WriteLine("*********************\n");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectangulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Circulo");
            Console.WriteLine("5. Salir");
        }

        static void CalcularCuadrado()
        {
            double lado = LeerDecimal("Ingrese el lado del cuadrado: ");
            double area = lado * lado;
            Console.WriteLine("El area del cuadrado es: " + area);
        }

        static void CalcularRectangulo()
        {
            double baserect = LeerDecimal("Ingrese la base del rectangulo: ");
            double alturarect = LeerDecimal("Ingrese la altura del rectangulo: ");
            double area = baserect * alturarect;
            Console.WriteLine("El area del rectangulo es: " + area);
        }

        static void CalcularTriangulo()
        {
            double basetri = LeerDecimal("Ingrese la base del triangulo: ");
            double alturatri = LeerDecimal("Ingrese la altura del triangulo: ");
            double area = (basetri * alturatri) / 2;
            Console.WriteLine("El area del triangulo es: " + area);
        }

        static void CalcularCirculo()
        {
            double radio = LeerDecimal("Ingrese el radio del circulo: ");
            double area = Math.PI * radio * radio;
            Console.WriteLine("El area del circulo es: " + area);
        }

        // Lee un entero validando la entrada; repite hasta que sea valido
        static int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Valor invalido, ingrese un numero entero: ");
            }
            return valor;
        }

        // Lee un decimal validando la entrada; repite hasta que sea valido
        static double LeerDecimal(string mensaje)
        {
            double valor;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Valor invalido, ingrese un numero: ");
            }
            return valor;
        }
    }
}