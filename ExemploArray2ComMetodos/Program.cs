using System;

namespace ExemploArrays2ComMetodos
{
    /**
     *  Exemplo tendo por base o exemplo: ExemploArrays2 com a utilização
     *  de métodos.
     *  Neste exemplo, foi adicionado um novo array para exemplificar
     *  as potencialidades de reutilização de código que os métodos
     *  disponibilizam.
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da constante para o número de elementos
            const int TAMANHO = 5;

            //Declaração dos arrays com o mesmo tamanho
            int[] numeros = new int[TAMANHO];
            int[] numeros2 = new int[TAMANHO];

            /**
             * Ambos os métodos criados para este exemplo, não têm retorno (void)
             * Quando utilizamos um array como parâmetro de um método estamos
             * a fazer uma passagem por referência. Isto significa que se alterarmos
             * o array dentro do método, essa alteração irá ser refletida em todos
             * os outros métodos onde o array será utilizado.
             */

            //invocação do método para leitura dos arrays
            lerArray(numeros, TAMANHO);
            lerArray(numeros2, TAMANHO);

            //invocação do método para imprimir os arrays
            imprimirArray(numeros, TAMANHO);
            imprimirArray(numeros2, TAMANHO);

        }

        /**
         * Os métodos possuem parâmetros que identificam as regras de
         * como esse método deverá ser utilizado. De notar que os parâmetros
         * podem ter o mesmo nome dos argumentos que são utilizados na invocação
         * do método. Neste exemplo, os argumentos e parâmetros têm nomes diferentes.
         * Os arrays: numeros e numeros2 são identificados internamente em cada um
         * dos métodos como arrayNumeros (termo mais genérico para referenciar qualquer
         * array enviado como argumento). Os parâmetros e variáveis de cada método
         * só existem no contexto do método, não sendo visíveis para os restantes
         * métodos do programa.
         * Tem que existir correspondência de tipos entre os parâmetros
         * e argumentos (int[] e int, respetivamente).
         * void significa que o método não tem retorno (a referência com o nome:
         * arrayNumeros altera diretamente os valores associados aos arrays enviados
         * por argumento no método main
         * 
         */
        static void lerArray(int[] arrayNumeros, int numeroElementos)
        {
            //input para o array
            for (int i = 0; i < numeroElementos; i++)
            {
                arrayNumeros[i] = int.Parse(Console.ReadLine());
            }
        }

        static void imprimirArray(int[] arrayNumeros, int numeroElementos)
        {
            //input para o array
            for (int i = 0; i < numeroElementos; i++)
            {
                Console.WriteLine(arrayNumeros[i]);
            }
        }
    }
}
