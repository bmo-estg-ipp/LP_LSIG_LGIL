using System;
namespace ExemploClasses3
{
    /**
     * A classe oficina tem um conjunto de carros que atualmente se
     * encontra nas instalações
     *
     */
    public class Workshop
    {
        private const byte TAMANHO = 5; //no máximo, existem 5 carros
        private string name;
        private Car[] cars = new Car[TAMANHO];

        //Método construtor
        public Workshop(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        /**
         * Método para adicionar um carro à oficina na primeira posição livre
         * O método recebe como parâmetro, o carro a adicionar
         * A palavra reservada null é utilizada para indicar ausência de valor
         * Quando um array de objetos é instanciado, todas as posições ficam
         * automaticamente com o valor "null"
         */
        public bool addCar(Car car)
        {
            //verificar se a instância de Car não é nula
            if(car != null)
            {
                /**
                 * procurar por uma posição livre (verificando primeiramente o tamanho e depois se a posição é nula
                 */
                byte i = 0;
                while (i < TAMANHO && this.cars[i] != null)
                {
                    i++;
                }
                if (i < TAMANHO)
                {
                    this.cars[i] = car;
                    return true;
                }
            }
            return false;

        }

        /**
         * Método para retornar um objeto que é instancia da classe Car
         * tendo por base a posição do array.
         * O método verifica se a posição é válida e caso não o seja,
         * retorna o valor null. De notar que um método poderá ter mais do que um
         * returno (return), mas apenas um deles é executado (o método termina
         * a execução após a invocação do comando return).
         */
        public Car getCar(int position)
        {
            if (position >= 0 && position < TAMANHO)
            {
                return this.cars[position];
            }
            return null;
        }

        /**
         * Método para "eliminar" um objeto tendo por base a posição do array.
         * O método verifica se a posição é válida e se a posição a remover não
         * tem o valor null. A estratégia para remover passa pela atribuição
         * do valor null à referida posição do objeto no array.
         *
         * De notar que um método poderá ter mais do que um
         * returno (return), mas apenas um deles é executado (o método termina
         * a execução após a invocação do comando return).
         * 
         */
        public bool removeCar(int position)
        {
            if(position >= 0 && position < TAMANHO && this.cars[position] != null)
            {
                this.cars[position] = null;
                return true;
            }
            return false;
        }

        /**
         * Método que imprime todos os elementos do array que não tenham o valor
         * null
         */
        public void printCars()
        {
            for(byte i = 0;i < TAMANHO; i++)
            {
                if (this.cars[i] != null)
                {
                    Console.WriteLine("Carro: " + (i + 1));
                    Console.WriteLine("Color: " + this.cars[i].getColor());
                    Console.WriteLine("Modelo: " + this.cars[i].getModel());
                }
            }
        }
    }
}
