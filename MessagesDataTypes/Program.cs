using System;

namespace MessagesDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            string Message = String.Empty;

            Console.WriteLine("Ingresa un mensaje en la consola: ");
            message = Console.ReadLine();

            Console.WriteLine($"Tu mensaje es: {Message}"); // No muestra nada
            Console.ReadKey();
        }
    }
}
