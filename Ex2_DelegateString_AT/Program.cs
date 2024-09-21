using System;

namespace Ex2_DelegateString_AT
{
    class Program
    {
        public delegate void Frase (string frase);

        static string LerFrase(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 2 - AT");

            string frase = LerFrase("Digite uma frase: ");

            // Declaração
            Frase maiusculas = delegate (string frase)
            {
                Console.WriteLine($"Maiúsculas: {frase.ToUpper()}");
            };

            Frase minusculas = delegate (string frase)
            {
                Console.WriteLine($"Minúsculas: {frase.ToLower()}");
            };

            maiusculas(frase);
            minusculas(frase);
        }
    }
}