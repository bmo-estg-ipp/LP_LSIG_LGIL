using System;
using System.IO;

namespace ExemploFicheirosTexto
{
    /**
     * Exemplo simples que demonstra como um array de strings pode ser escrito
     * e lido em/de ficheiro utilizando uma stream de strings.
     *
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            const byte SIZE = 3;

            string[] lines = { "First line", "Second line", "Third line" };

            //Escrever em ficheiro
            StreamWriter writer;
            writer = new StreamWriter("test.txt");

            for(int i = 0;i < SIZE; i++)
            {
                writer.WriteLine(lines[i]);
            }

            writer.Close();

            string[] lines2 = new string[SIZE];

            //Ler de ficheiro para um novo array
            StreamReader reader = new StreamReader("test.txt");

            int j = 0;
            while (reader.EndOfStream == false)
            {
                lines2[j] = reader.ReadLine();
                j++;
            }

            reader.Close();

            //imprimir para verificar o resultado
            for (int i = 0; i < SIZE; i++)
            {
                Console.WriteLine(lines2[i]);
            }


        }
    }
}
