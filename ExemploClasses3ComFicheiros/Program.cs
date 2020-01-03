using System;

namespace ExemploClasses3ComFicheiros
{
    /**
     * Exemplo que apresenta a declaração de uma classe Car e a sua utilização
     * numa class Program para armazenar um conjunto de Cars. Em relação
     * ao exemplo: ExemploClasses3, este exemplo inclui os exemplos de ler e
     * escrever dados em ficheiro no modo binário.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Workshop myWorkshop = new Workshop("Oficina1");
            byte option, pos;
            bool res;

            do
            {
                Console.WriteLine("Escolha uma das opções:\n " +
                    "1- Adicionar carro \n " +
                    "2- Retornar carro\n " +
                    "3- Remover Carro\n " +
                    "4- Imprimir todos os carros\n" +
                    "5- Ler de ficheiro\n " +
                    "6- Escrever para ficheiro\n" +
                    "0- Sair ");
                option = byte.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        string color, model;
                        Console.WriteLine("Introduza a cor");
                        color = Console.ReadLine();
                        Console.WriteLine("Introduza o modelo");
                        model = Console.ReadLine();

                        Car newCar = new Car(color, model);
                        res = myWorkshop.addCar(newCar);

                        if (res)
                        {
                            Console.WriteLine("Inserido com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao inserir");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Qual é a posição?");
                        pos = byte.Parse(Console.ReadLine());

                        Car returnedCar = myWorkshop.getCar(pos);
                        if (returnedCar != null)
                        {
                            Console.WriteLine("Color: " + returnedCar.getColor());
                            Console.WriteLine("Modelo: " + returnedCar.getModel());
                        }
                        else
                        {
                            Console.WriteLine("Erro ao retornar");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Qual é a posição?");
                        pos = byte.Parse(Console.ReadLine());

                        res = myWorkshop.removeCar(pos);

                        if (res)
                        {
                            Console.WriteLine("Removido com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao remover");
                        }

                        break;
                    case 4:
                        myWorkshop.printCars();
                        break;
                    case 5:
                        myWorkshop.readFromFile();
                        break;
                    case 6:
                        myWorkshop.writeToFile();
                        break;
                }

            } while (option != 0);
        }
    }
}
