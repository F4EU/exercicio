using System;

namespace vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Digite seu Nome:");

            string nome = Console.ReadLine();

            int vogais = 0;
            int consoante = 0;



            foreach (char letra in nome)
            {
                if (letra.Equals('A') || letra.Equals('a') || letra.Equals('E') || letra.Equals('e') ||
                        letra.Equals('I') || letra.Equals('i') || letra.Equals('O') || letra.Equals('o')
                        || letra.Equals('U') || letra.Equals('U'))
                {
                    vogais++;
                }
                else
                {
                    consoante++;

                }

            }

            Console.WriteLine($"Vogais: {vogais}");

            Console.WriteLine($"Consoantes: {consoante}");

        }
    }
}
