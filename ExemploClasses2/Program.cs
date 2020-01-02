using System;

namespace ExemploClasses2
{
    /**
     * Exemplo que apresenta a declaração de uma classe Car e a sua utilização
     * numa class Program para armazenar um conjunto de Cars.
     */
    class Program
    {
        static void Main(string[] args)
        {
            const byte TAMANHO = 5;
            //declaração de um array de Car
            Car[] myCars = new Car[TAMANHO];

            for(byte i = 0; i < TAMANHO;i++)
            {
                //variáveis locais para temporariamente armazenarem os dados de cada carro
                string color, model;
                Console.WriteLine("Introduza a cor");
                color = Console.ReadLine();
                Console.WriteLine("Introduza o modelo");
                model = Console.ReadLine();

                //instanciação do objeto Car em cada uma das posições do array
                myCars[i] = new Car(color, model);
            }

            Console.WriteLine("Os carros são: ");
            for (byte i = 0; i < TAMANHO; i++)
            {
                Console.WriteLine("Carro: " + (i + 1));
                Console.WriteLine("Color: " + myCars[i].getColor());
                Console.WriteLine("Modelo: " + myCars[i].getModel());

            }
        }
    }
}
