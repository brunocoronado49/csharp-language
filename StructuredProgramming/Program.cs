using System;

namespace StructuredProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool newOperation = true;
            double result;
            double firstNumber;
            double secondNumber;
            double numberOperator;
            string response;

            while (newOperation)
            {
                Console.WriteLine("Hola, soy tu nueva mini calculadora.");
                numberOperator = GetIntDataUser("Ingresa una opcion: (1. suma/ 2. resta/ 3. multiplicacion/ 4. salir)");

                switch(numberOperator)
                {
                    case 1:
                        Console.WriteLine("SUMA");
                        firstNumber = GetIntDataUser("Ingresa el primer numero: ");
                        secondNumber = GetIntDataUser("Ingresa el segundo numero: ");
                        Console.WriteLine($"El resultado de la suma es: {firstNumber + secondNumber}");
                        break;
                    case 2:
                        Console.WriteLine("RESTA");
                        firstNumber = GetIntDataUser("Ingresa el primer numero: ");
                        secondNumber = GetIntDataUser("Ingresa el segundo numero: ");
                        Console.WriteLine($"El resultado de la resta es: {firstNumber - secondNumber}");
                        break;
                    case 3:
                        Console.WriteLine("MULTIPLICACION");
                        firstNumber = GetIntDataUser("Ingresa el primer numero: ");
                        secondNumber = GetIntDataUser("Ingresa el segundo numero: ");
                        Console.WriteLine($"El resultado de la multiplicacion es: {firstNumber * secondNumber}");
                        break;
                    case 4:
                        Console.WriteLine("Seguro que quieres salir? [s] - [n]");
                        response = Console.ReadLine();

                        if(response == "s" || response == "S")
                        {
                            newOperation = false;
                        }
                        break;
                }
            }
        }

        public static double GetIntDataUser(string message)
        {
            string userData;
            int data = 0;
            bool isValidData = false;

            while(!isValidData)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();

                if(!int.TryParse(userData, out data))
                {
                    Console.WriteLine("El dato que ingresaste no es valido");
                }
                else
                {
                    isValidData = true;
                }
            }

            return data;
        }
    }
}
