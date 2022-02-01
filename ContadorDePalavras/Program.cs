using System;
using System.Globalization;

namespace ContadorDePalavras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a frase: ");
            string frase = Console.ReadLine();
            string fraseMinuscula = frase.ToLower(new CultureInfo("pt-BR", false));
            Console.WriteLine("Digite qual palavra esta procurando: ");
            string letra = Console.ReadLine();
            char letraMinuscula = char.Parse(letra.ToLower(new CultureInfo("pt-BR", false)));
            int contador = 0;
            
            

            for (int i = 0; i < fraseMinuscula.Length; i++)
            {
                if (letraMinuscula == fraseMinuscula[i])
                {
                    contador++;
                }
            }

            Console.WriteLine("A letra " + letra + " repete: " + contador + " vezes");
            Console.WriteLine("Aperte enter para sair");
            Console.ReadLine();
        }
    }
}
