using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis
            double minutos, segundos;
            string minutosString;

            //Leitura do teclado
            Console.WriteLine("Introduza os minutos:");
            minutosString = Console.ReadLine();

            //conversão da string lida do teclado para double
            minutos = double.Parse(minutosString);

            //cálculo dos segundos
            segundos = minutos * 60;

            //imprimir resultados
            Console.WriteLine("Resultado: "+ segundos);

            /**
            * Instrução facultativa que faz com que o programa apenas termine
            * após a introdução de algum valor
            */
            Console.ReadKey();
		}
    }

