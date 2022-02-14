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

            WriteLine($"O que deseja fazer?");
            WriteLine("1 - Soma");
            WriteLine("2 - Subtração");
            WriteLine("3 - Divisão");
            WriteLine("4 - Multiplicação");
            WriteLine("5 - Sair");

            WriteLine("---------");
            WriteLine("Selecione uma opção: ");
            short opcao = short.Parse(ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Soma()
        {
            Console.Clear();

            WriteLine("Primeiro Valor da Soma é: ");
            float v1 = float.Parse(ReadLine());

            WriteLine("Segundo Valor da Soma é: ");
            float v2 = float.Parse(ReadLine());

            WriteLine("");

            float resultado = v1 + v2;
            WriteLine($"O resultado da soma é: {resultado}");
            ReadKey();

            Menu();
        }
        static void Subtracao()
        {
            Clear();

            WriteLine("Primeiro Valor da Subtração é: ");
            float v1 = float.Parse(ReadLine());

            WriteLine("Segundo Valor da Subtração é:");
            float v2 = float.Parse(ReadLine());

            WriteLine("");

            float resultado = v2 - v1;
            WriteLine($"O Resultado da Subtração é: {resultado}");
            ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Clear();

            WriteLine("Primeiro valor da Divisão é:");
            float v1 = float.Parse(ReadLine());

            WriteLine("Segundo valor da Divisão é:");
            float v2 = float.Parse(ReadLine());

            WriteLine("");

            float resultado = v1 / v2;
            WriteLine($"O Resultado da Divisão é: {resultado}");
            ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Clear();

            WriteLine("O Primeiro valor da Multiplicação é: ");
            float v1 = float.Parse(ReadLine());

            WriteLine("");

            WriteLine("O Segundo valor da Multiplicação é: ");
            float v2 = float.Parse(ReadLine());

            float resultado = v1 * v2;
            WriteLine($"O Resultado da Multiplicação é: {resultado}");
            ReadKey();

            Menu();

        }
    }

}
