using System;

/**
 *  Exemplo de programa que declara um array,
 *  lê um conjunto de 10 valores para um array e imprime-os
 *  de seguida
 *
 */

namespace ExemploArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da constante para o número de elementos
            const int TAMANHO = 10;

            //Declaração do array
            int[] numeros = new int[TAMANHO];


            //input para o array
            for (int i = 0; i < TAMANHO; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            //output
            for (int i = 0; i < TAMANHO; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
