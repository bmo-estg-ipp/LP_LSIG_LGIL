using System;

namespace ExemploMetodos
{
    /**
     * Neste exemplo pretende-se ler a altura e comprimento de uma janela
     * tendo por base as seguintes restrições:
     * valor da altura entre 0.5 e 5
     * valor do comprimento entre 1 e 6
     * No final imprime a área da janela
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de constantes para os limites
            const double MIN_ALTURA = 0.5, MAX_ALTURA = 5, MIN_COMP = 1, MAX_COMP = 6;
            //Declaração de variáveis
            double altura, comprimento, area;

            //ler os valores utilizando o método lerValor
            altura = LerValor(MIN_ALTURA, MAX_ALTURA);
            comprimento = LerValor(MIN_COMP, MAX_COMP);

            //apresentar cálculo
            area = comprimento * altura;

            Console.WriteLine("A área é: " + area);
        }

        /**
         * Caso os valores não estejam nos limites estipulados,
         * o retorno assume o mínimo caso seja inferior a esse mínimo
         * e assume o máximo caso seja superior a esse máximo
         *
         * Neste exemplo, o método retorna um valor do tipo double.
         * Nas variáveis do tipo primitivo sé realizada uma passagem por valor.
         * Isto é, é sempre enviada uma cópia do valor enviado como argumento,
         * o que significa que alterações aos valores
         * dos parâmetros (dentro do método) não têm impacto no valor dos argumentos
         * enviados por outros métodos na invocação do método.
         */
        static double LerValor(double min, double max)
        {
            double valor;
            valor = double.Parse(Console.ReadLine());
            if(valor < min)
            {
                valor = min;
            }
            if(valor > max)
            {
                valor = max;
            }

            return valor;
        }
    }
}
