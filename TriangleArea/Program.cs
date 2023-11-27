using System;

namespace TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula el area de un triangulo....");
            Console.WriteLine("     /\\     ");
            Console.WriteLine("    /  \\    ");
            Console.WriteLine("   /    \\   ");
            Console.WriteLine("  _________  ");

            string baseUser;
            string alturaUser;
            double b;
            double h;
            double area;

            Console.WriteLine("Ingresa la base del triangulo:");
            baseUser = Console.ReadLine();
            Console.WriteLine("Ingresa la altura del triangulo:");
            alturaUser = Console.ReadLine();

            if(double.TryParse(baseUser, out b))
            {
                if(double.TryParse(alturaUser, out h))
                {
                    area = (b * h) / 2;
                    Console.WriteLine($"El area del triangulo es: {area}");
                    Console.ReadKey();
                } else
                {
                    Console.WriteLine("Error al parsear la altura");
                    Console.ReadKey();
                }
            } else
            {
                Console.WriteLine("Error al parsear la base");
                Console.ReadKey();
            }
        }
    }
}
