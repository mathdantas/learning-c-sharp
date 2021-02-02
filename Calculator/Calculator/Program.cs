using System;

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
            Console.Clear();

            Console.WriteLine("CALCULADORA");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------------");
            Console.WriteLine("Selecione uma opção:");

            short op = short.Parse(Console.ReadLine());

            switch(op)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }



        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float soma = v1 + v2;
            Console.WriteLine($"\nResultado: {soma}");

            Console.ReadKey();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float subtracao = v1 - v2;
            Console.WriteLine($"\nResultado: {subtracao}");

            Console.ReadKey();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float divisao = v1 / v2;
            Console.WriteLine($"\nResultado: {divisao}");

            Console.ReadKey();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float multiplicacao = v1 * v2;
            Console.WriteLine($"\nResultado: {multiplicacao}");

            Console.ReadKey();
        }
    }
}
