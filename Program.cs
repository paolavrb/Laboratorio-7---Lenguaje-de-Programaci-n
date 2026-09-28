using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n*********************");
                Console.WriteLine("Calculadora de areas");
                Console.WriteLine("*********************\n");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Rectangulo");
                Console.WriteLine("3. Triangulo");
                Console.WriteLine("4. Circulo");
                Console.Write("\nElige una opcion:");
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.Write("Ingrese el lado del cuadrado:");
                    double lado = double.Parse(Console.ReadLine());
                    double area = lado * lado;
                    Console.WriteLine("El area del cuadrado es: " + area);
                }
                else if (op == 2)
                {
                    Console.Write("Ingrese la base del rectangulo:");
                    double baserect = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del rectangulo:");
                    double alturarect = double.Parse(Console.ReadLine());
                    double area = baserect * alturarect;
                    Console.WriteLine("El area del rectanguilo es:" + area);
                }
                else if (op == 3)
                {
                    Console.Write("Ingrese la base del triangulo:");
                    double basetri = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del triangulo:");
                    double alturatri = double.Parse(Console.ReadLine());
                    double area = (basetri * alturatri) / 2;
                    Console.WriteLine("El area del triangulo es:" + area);
                }
                else if (op == 4)
                {
                    Console.Write("Ingrese el radio del circulo:");
                    double radio = double.Parse(Console.ReadLine());
                    double area = Math.PI * radio * radio;
                    Console.WriteLine("El area del circulo es:" + area);
                }
                else
                {
                    Console.WriteLine("\nOpcion invalida");
                }
                Console.WriteLine("\nPresiona una tecla para volver al menú");
                Console.ReadKey();
            }
        }
    }
}
