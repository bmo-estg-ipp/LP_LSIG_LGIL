using System;
/**
 * Exemplo - Glazer Calc com constantes e estruturas de decisão
 */
public class GlazerCalc
{
    public static void Main()
    {
        //Declaração de variáveis do tipo double (números reais)
        double width, height, woodLength, glassArea;

        //constantes
        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;
        const double MAX_HEIGHT = 3.0;
        const double MIN_HEIGHT = 0.75;

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

        //Validação do comprimento
        if (width < MIN_WIDTH){
            Console.WriteLine("Width is too small.\n\n "); Console.WriteLine("Using minimum"); width = MIN_WIDTH;
        }
        if (width > MAX_WIDTH){
            Console.WriteLine("Width is too large.\n\n"); Console.WriteLine("Using maximum"); width = MAX_WIDTH;
        }

        /**
         * Apresenta mensagem para que o utilizador introduza o comprimento
         * da janela
         */
        Console.Write("Give the height of the window : ");
        //Leitura do teclado
        heightString = Console.ReadLine();
        //Conversão do valor (em texto) lido do teclado para um número real
        height = double.Parse(heightString);

        //Validação da altura
        if (height < MIN_HEIGHT)
        {
            Console.WriteLine("Height is too small.\n\n"); Console.WriteLine("Using minimum"); height = MIN_HEIGHT;
        }
        if (height > MAX_HEIGHT)
        {
            Console.WriteLine("Height is too large.\n\n"); Console.WriteLine("Using maximum"); height = MAX_HEIGHT;
        }

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