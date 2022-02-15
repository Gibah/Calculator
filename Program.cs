using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Clear();

            WriteLine($"What do you wanna do?");
            WriteLine("1 - Sum");
            WriteLine("2 - Subtraction");
            WriteLine("3 - Division");
            WriteLine("4 - Multiplication");
            WriteLine("5 - Quit");

            WriteLine("---------");
            WriteLine("Choose one Option: ");
            short opcao = short.Parse(ReadLine());

            switch (opcao)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Sum()
        {
            Console.Clear();

            WriteLine("First Sum Value is: ");
            float v1 = float.Parse(ReadLine());

            WriteLine("Second Sum Value is: ");
            float v2 = float.Parse(ReadLine());

            WriteLine("");

            float resultado = v1 + v2;
            WriteLine($"The Sum's Result is: {resultado}");
            ReadKey();

            Menu();
        }
        static void Subtraction()
        {
            Clear();

            WriteLine("First Subtraction Value is: ");
            float v1 = float.Parse(ReadLine());

            WriteLine("Second Subtraction Value is:");
            float v2 = float.Parse(ReadLine());

            WriteLine("");

            float resultado = v2 - v1;
            WriteLine($"The Subtraction's Result is: {resultado}");
            ReadKey();

            Menu();
        }

        static void Division()
        {
            Clear();

            WriteLine("First Division Value is:");
            float v1 = float.Parse(ReadLine());

            WriteLine("Second Division Value is:");
            float v2 = float.Parse(ReadLine());

            WriteLine("");

            float resultado = v1 / v2;
            WriteLine($"The Division's Result is: {resultado}");
            ReadKey();

            Menu();
        }

        static void Multiplication()
        {
            Clear();

            WriteLine("First Multiplication Value is: ");
            float v1 = float.Parse(ReadLine());

            WriteLine("");

            WriteLine("Second Multiplication Value is: ");
            float v2 = float.Parse(ReadLine());

            float resultado = v1 * v2;
            WriteLine($"The Multiplication's Result is: {resultado}");
            ReadKey();

            Menu();
        }
    }
}
