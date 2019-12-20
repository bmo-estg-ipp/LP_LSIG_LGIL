using System;

/**
 *  Exemplo de programa que declara um array,
 *  atribui um conjunto de 5 valores ao array e imprime-os
 *  de seguida
 *
 */

class Program
{
    static void Main(string[] args)
    {
        //Declaração da constante para o número de elementos
        const int TAMANHO = 5;
        /**Declaração do array, seguida de uma inicialização
        * de cada um dos seus elementos
        */
        int[] numeros = new int[TAMANHO];
        numeros[0] = 1;
        numeros[1] = 2;
        numeros[2] = 3;
        numeros[3] = 4;
        numeros[4] = 5;

        //output do contéudo do array
        for(int i = 0;i < TAMANHO; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}

