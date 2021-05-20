using System;

namespace TP1
{
    class Tp1
    {

        enum Menu { Soma = 1, Subtracao, Multiplicacao, Divisao, Sair}

        static void Main(string[] args)
        {
            Console.WriteLine("**********Calculadora**********");

            bool exit = false;
            while (!exit) //Enqto o usuário NÃO escolher sair, continue exibindo o menu...
            {
                Console.WriteLine("Selecione a opção desejada!");
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair");
                Console.WriteLine();

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Sub();
                        break;

                    case Menu.Multiplicacao:
                        Mult();
                        break;

                    case Menu.Divisao:
                        Div();
                        break;

                    case Menu.Sair:
                        exit = true;
                        break;
                }
                Console.Clear();
            }            
        }

        static void Soma()
        {
            int a;
            int b;
            Console.WriteLine();
            Console.WriteLine("A opção desejada foi soma.");

            Console.WriteLine();
            Console.Write("Digite o primeiro nº: ");
            while(!int.TryParse(Console.ReadLine(), out a)) //Verifica se o que foi digitado é número
            {
            Console.WriteLine("Erro! Insira apenas números inteiros.");
            }

            Console.Write("Digite o segundo nº: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Erro! Insira apenas números inteiros.");
            }

            int resultado = a + b;
            Console.WriteLine($"O resultado da soma de {a} e {b} é: {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }

        static void Sub()
        {
            int a;
            int b;
            Console.WriteLine();
            Console.WriteLine("A opção desejada foi subtração.");

            Console.WriteLine();
            Console.Write("Digite o primeiro nº: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Erro! Insira apenas números inteiros.");
            }

            Console.Write("Digite o segundo nº: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Erro! Insira apenas números inteiros.");
            }

            int resultado = a - b;
            Console.WriteLine($"O resultado da subtração de {a} e {b} é: {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }

        static void Mult()
        {
            int a;
            int b;
            Console.WriteLine();
            Console.WriteLine("A opção desejada foi multiplicação.");

            Console.WriteLine();
            Console.Write("Digite o primeiro nº: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Erro! Insira apenas números inteiros.");
            }

            Console.Write("Digite o segundo nº: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Erro! Insira apenas números inteiros.");
            }

            int resultado = a * b;
            Console.WriteLine($"O resultado da multiplicação de {a} e {b} é: {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }

        static void Div()
        {
            int a;
            int b;
            Console.WriteLine();
            Console.WriteLine("A opção desejada foi divisão.");

            Console.WriteLine();
            Console.Write("Digite o primeiro nº: ");
            while (!int.TryParse(Console.ReadLine(), out a))
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
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
    }
}

