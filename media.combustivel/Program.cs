using System;

namespace media.combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Informe a quilometragem rodada");
            string kmPercorrido = Console.ReadLine();
            decimal kmConvertido = 0.0m;

            Console.WriteLine("informe a quantidade de litros ultilizada");
            string litros = Console.ReadLine();
            decimal litrosConvertido = 0.0m;

            decimal.TryParse(kmPercorrido, out kmConvertido);
            decimal.TryParse(litros, out litrosConvertido);

            decimal mediaGasta = kmConvertido / litrosConvertido;

            Console.WriteLine($"seu veiculo fez: {mediaGasta} km rodado por litro gasto");
        }
    }
}
