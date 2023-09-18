using System;

namespace JogoDaForca
{
    public class Program
    {
        static void Main(string[] args)
        {
            string palavraChave = "";
            Console.WriteLine("Digite a palavra-chave:");
            palavraChave = Console.ReadLine();
            Console.Clear();

            string[] letrasCorretas = new string[palavraChave.Length];
            int numeroTentativas = 0;
            int quantidadeAcertos = 0;
            int numeroMaximoTentativas = 6;

            

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
                            quantidadeAcertos++;
                        }
                    }
                    Console.WriteLine($"Palavra: {string.Join(" ", letrasCorretas)}");
                }
                else
                {
                    Console.WriteLine($"A palavra não contem a letra {letra}");
                    numeroTentativas++;
                    Console.WriteLine($"Você tem mais {numeroMaximoTentativas - numeroTentativas} Tentativas");                    
                } 
                if (quantidadeAcertos == palavraChave.Length)
                {
                    Console.Clear();
                    Console.WriteLine("Meus parabéns você acertou a palavra");
                    break;
                }
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
                    default:
                        Console.WriteLine("|----");
                        Console.WriteLine("|    ");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        break;

                }

            } while (numeroTentativas < numeroMaximoTentativas && quantidadeAcertos < palavraChave.Length);

            

        }
    }
}