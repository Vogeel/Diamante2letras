using System;
namespace Diamante2.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        volta:
            Console.WriteLine("digite uma letra");
            string stringDigitado = Console.ReadLine().ToUpper();
            if (!(char.TryParse(stringDigitado, out char letra)))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ReadKey();
                Console.ResetColor();
                goto volta;
            }
            int numeroDoLetraDe65A90 = (int)letra; // numero de ASCII

            int numeroDaLetraDe0A25 = numeroDoLetraDe65A90 - 65; //numero de 0 a 25 para as letras do alfabeto
                    
            for (int linhas = 0; linhas <= numeroDaLetraDe0A25; linhas++) // Rodar até o letra colocada
            {
                for (int numerolinha = -(numeroDaLetraDe0A25 + 1) / 2; numerolinha <= numeroDaLetraDe0A25 + (numeroDaLetraDe0A25 / 2); numerolinha++)// fazer colunas
                                                                                                                                         
                                                                                                                                        
                                                                                                                                         
                {
                    if (numerolinha > ((numeroDaLetraDe0A25) / 2) + linhas)
                        break;//evitar mais espaçoes do que necessario
                    if (numerolinha == ((numeroDaLetraDe0A25) / 2) - linhas || numerolinha == ((numeroDaLetraDe0A25) / 2) + linhas)
                    // minimos e maximo da cada linha
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($"{(char)(65 + linhas)}");// descobrir a letra que deve aparecer
                        Console.ResetColor();
                    }
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
                      
            for (int linhas = 1; linhas <= numeroDaLetraDe0A25; linhas++)
            {
                for (int colunas = -(numeroDaLetraDe0A25 + 1) / 2; colunas <= numeroDaLetraDe0A25 + (numeroDaLetraDe0A25 / 2); colunas++)
                // mesma logica
                {
                    if (colunas > ((numeroDaLetraDe0A25) / 2) + (numeroDaLetraDe0A25 - linhas))
                        break; //evitar escrever mais espaçoes do que necessario
                    if (colunas == ((numeroDaLetraDe0A25) / 2) - (numeroDaLetraDe0A25 - linhas) || colunas == ((numeroDaLetraDe0A25) / 2) + (numeroDaLetraDe0A25 - linhas))
                    //  minimo e maximo de cada linha
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($"{(char)(numeroDoLetraDe65A90 - linhas)}");
                        Console.ResetColor();
                    }
                    else
                        Console.Write(" ");


                }
                Console.WriteLine();
            }
            

            Console.ReadKey();

        }
    }
}



