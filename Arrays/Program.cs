using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            names[0] = "Francisco";
            names[1] = "Bruce";
            names[2] = "Maria";
            Console.WriteLine($"Names: {names[0]}, {names[1]}, {names[2]}");

            int[] years = {1, 2, 3, 4, 5};
            Console.WriteLine($"Years: {years[1]}, {years[3]}");

            bool[] singles;
            singles = new bool[] {true, false, true, true, false};

            foreach (bool item in singles)
            {
                Console.WriteLine(item);
            }

            int[][] arrayOfArrays = new int[2][];
            arrayOfArrays[0] = new int[] { 1 };
            arrayOfArrays[1] = new int[] { 2, 3, 4 };

            foreach (int[] item in arrayOfArrays)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item);
                foreach (int subitem in item)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(subitem);
                }
            }

            Console.WriteLine($"Elements in names: {names.Length}");
            Console.WriteLine($"Elements in years: {years.Length}");
            Console.WriteLine($"Elements in singles: {singles.Length}");
            Console.WriteLine($"Elements in arrayOfArrays: {arrayOfArrays.Length}");

            Console.ReadKey();
        }
    }
}
