using System;

/**
 *  Exemplo de utilização da estrutura de repetição: while
 *  Apresenta os números de 1 a 20
 */
namespace ExemploWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
