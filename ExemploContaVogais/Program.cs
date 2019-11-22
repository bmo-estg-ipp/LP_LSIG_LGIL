using System;

namespace ExemploContaVogais
{
    class Program
    {
        /**
         * Exemplo de programa que permite contar o número de cada uma
         * das vogais introduzidas pelo utilizador
         * Exemplo criado com o propósito de abordar:
         *      - Estruturas condicionais: if - else e switch - case
         *      - Estrutura de repetição: do - while
         *
         */
        static void Main(string[] args)
        {
			const char sair1 = 's', sair2 = 'S';
			char letra;
			int numA = 0, numE = 0, numI = 0, numO = 0, numU = 0;

			Console.WriteLine("Introduza vogais (s para sair)");
			do
			{
				letra = char.Parse(Console.ReadLine());
				switch (letra)
				{
					case 'a':
					case 'A':
						numA++;
						break;
					case 'e':
					case 'E':
						numE++;
						break;
					case 'i':
					case 'I':
						numI++;
						break;
					case 'o':
					case 'O':
						numO++;
						break;
					case 'u':
					case 'U':
						numU++;
						break;
					default:
						if (letra != sair1 && letra != sair2)
						{
							Console.WriteLine("Caracter inválido");
						}
						break;

				}

			} while (letra != sair1 && letra != sair2);

			Console.WriteLine("numA: " + numA + "\n"
										+ "numE: " + numE + "\n"
										+ "numI: " + numI + "\n"
										+ "numO: " + numO + "\n"
										+ "numU: " + numI + "\n");
		}
    }
}
