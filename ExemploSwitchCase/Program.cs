using System;
/**
 * Exemplo que apresenta a aplicação da estrutura condicional: switch-case
 */
namespace CalculatorSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, total=0;
            char operador; //O tipo char armazena um carater
            string valor1String, valor2String, operadorString;

            Console.WriteLine("Introduza o valor 1");
            valor1String = Console.ReadLine();
            valor1 = double.Parse(valor1String);

            Console.WriteLine("Introduza o valor 2");
            valor2String = Console.ReadLine();
            valor2 = double.Parse(valor2String);

            Console.WriteLine("Introduza o operador atitmético (+,-,/,*)");
            operadorString = Console.ReadLine();
            operador = char.Parse(operadorString);

            switch (operador)
            {
                case '+':
                    total = valor1 + valor2;
                break;
                case '-':
                    total = valor1 - valor2;
                break;
                case '/':
                    total = valor1 / valor2;
                break;
                case '*':
                    total = valor1 * valor2;
                break;
                default:
                    Console.WriteLine("Operador inválido");
                break;
            }
            Console.WriteLine("O resultado é: " + total);

        }
    }
}
