using System;
/**
 * Exemplo - Ficha prática 1
 */
public class GlazerCalc
{
    public static void Main()
    {
        //Declaração de variáveis do tipo double (números reais)
        double width, height, woodLength, glassArea;
        /**
         * Declaração de variáveis auxiliares do tipo string (texto).
         * São utilizadas para armazenar os valores introduzidos pelo
         * utilizador em formato de texto
         */
        string widthString, heightString;

        /**
         * Apresenta mensagem para que o utilizador introduza o comprimento
         * da janela
         */
        Console.Write("Give the width of the window : ");
        //Leitura do teclado
        widthString = Console.ReadLine();
        //Conversão do valor (em texto) lido do teclado para um número real
        width = double.Parse(widthString);

        /**
         * Apresenta mensagem para que o utilizador introduza o comprimento
         * da janela
         */
        Console.Write("Give the height of the window : ");
        //Leitura do teclado
        heightString = Console.ReadLine();
        //Conversão do valor (em texto) lido do teclado para um número real
        height = double.Parse(heightString);

        //Calcular a quantidade de madeira e área do vidro
        woodLength = 2 * (width + height) * 3.25;
        glassArea = width * height;

        //Apresentação de resultados
        Console.WriteLine("The length of the wood is " + woodLength + " feet");
        Console.WriteLine("The area of the glass is " + glassArea + " square metres");

        /**
         * Instrução facultativa que faz com que o programa apenas termine
         * após a introdução de algum valor
         */
        Console.ReadKey();
    }
}
