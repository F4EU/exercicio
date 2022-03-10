using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string valor1 = Console.ReadLine();
            Console.WriteLine("informe o primeirovalor");
            decimal valor1Convertido = 0.0m;
            decimal.TryParse(valor1, out valor1Convertido);

            Console.WriteLine("informe o segundo valor");
            string valor2 = Console.ReadLine();
            decimal valor2Convertido = 0.0.m;
            decimal.TryParse(valor2, out valor2Convertido);

            decimal resultado = 0.0m;

            Console.WriteLine($"ESCOLHA A OPERAÇÃO DESEJADA: ");
            Console.WriteLine($" 1 - SOMA.");
            Console.WriteLine($" 2 - SUBTRAÇÃO.");
            Console.WriteLine($" 3 - MULTIPLICAÇÃO.");
            Console.WriteLine($" 4 - DIVISÃO.");
            Console.WriteLine($" 5 - RESTO DA DIVISÃO.");

            int.TryParse(Console.ReadLine(), out int op);

            switch (op) {
                case 1:
                    resultado = valor1Convertido + valor2Convertido;
                    Console.WriteLine($"resultado da soma {valor1Convertido} + {valor2Convertido} = {resultado}");
                    break;

                case 2:
                    resultado = valor1Convertido + valor2Convertido;
                    Console.WriteLine($"resultado da subtração {valor1Convertido} - {valor2Convertido} = {resultado}");
                    break;

                case 3:
                    resultado = valor1Convertido + valor2Convertido;
                    Console.WriteLine($"resultado da soma {valor1Convertido} * {valor2Convertido} = {resultado}");
                    break;

                case 4:
                    resultado = valor1Convertido + valor2Convertido;
                    Console.WriteLine($"resultado da soma {valor1Convertido} / {valor2Convertido} = {resultado}");
                    break;

                case 5:
                    resultado = valor1Convertido % valor2Convertido;
                    Console.WriteLine($"resultado do resto da divisão é {resultado}");
                    break;

                default:
                    Console.WriteLine($"operação não encontrada");
                    break;

            }
            Console.ReadLine();




        }
    }
}
