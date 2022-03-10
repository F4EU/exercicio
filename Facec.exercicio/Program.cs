using System;

namespace Facec.exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Insira o ano de nascimento:");
            string anoNascimento = Console.ReadLine();
            int anoNConvertido = 0;
            int.TryParse(anoNascimento, out anoNConvertido);

            int anoAniversario = DateTime.Today.Year;
            int idade = anoAniversario - anoNConvertido;

            Console.WriteLine($"Idade : {idade}");
            Console.ReadLine();
        }
    }
}
