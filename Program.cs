using System;

namespace JogoDaForca
{
    public class Program
    {
        static void Main(string[] args)
        {
            string palavraChave = "banana";
            string[] letrasCorretas = new string[palavraChave.Length];
            int numeroTentativas = 0;
            int numeroMaximoTentativas = palavraChave.Length;

            do
            {                
                Console.WriteLine("informe uma letra");
                string letra = Console.ReadLine().ToLower();

                if (palavraChave.ToLower().Contains(letra))
                {
                    for (int i = 0; i < palavraChave.Length; i++)
                    {
                        if (palavraChave[i].ToString() == letra)
                        {
                            letrasCorretas[i] = letra;                            
                        }
                    }
                    Console.WriteLine($"Palavra: {string.Join(" ", letrasCorretas)}");
                }
                else
                {
                    Console.WriteLine($"A palavra não contem a letra {letra}");
                    numeroTentativas++;
                    Console.WriteLine($"Você tem mais {numeroMaximoTentativas - numeroTentativas} Tentativas");
                    switch (numeroTentativas)
                    {
                        case 1:
                            Console.WriteLine("|----");
                            Console.WriteLine("|    O");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            break;
                        case 2:
                            Console.WriteLine("|----");
                            Console.WriteLine("|    O");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            break;
                        case 3:
                            Console.WriteLine("|----");
                            Console.WriteLine("|    O");
                            Console.WriteLine("|   /|");
                            Console.WriteLine("|    ");
                            Console.WriteLine("|");
                            break;
                        case 4:
                            Console.WriteLine("|----");
                            Console.WriteLine("|    O");
                            Console.WriteLine("|   /|\\");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            break;
                        case 5:
                            Console.WriteLine("|----");
                            Console.WriteLine("|    O");
                            Console.WriteLine("|   /|\\");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|   / ");
                            break;
                        case 6:
                            Console.WriteLine("|----");
                            Console.WriteLine("|    O");
                            Console.WriteLine("|   /|\\");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|   / \\");
                            break;
                    }
                }

            } while (numeroTentativas < numeroMaximoTentativas);

            

        }
    }
}