using System;

namespace Divisao
{
    class Divisao
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Esse projeto realiza divisão.");

            Console.WriteLine();
            Console.Write("Digite o primeiro nº: ");
            while (!int.TryParse(Console.ReadLine(), out a)) //Verifica se o que foi digitado é número
            {
                Console.WriteLine("Erro! Insira apenas números inteiros.");
            }

            Console.Write("Digite o segundo nº: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Erro! Insira apenas números inteiros.");
            }

            int resultado = a / b;
            Console.WriteLine($"O resultado da divisão de {a} e {b} é: {resultado}");
        }
    }
}
