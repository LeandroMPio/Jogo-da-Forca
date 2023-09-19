using System;
using System.Text.RegularExpressions;

namespace JogoDaForca
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numeroTentativas = 0;
            int quantidadeAcertos = 0;
            int numeroMaximoTentativas = 6;

            string palavraChave = "";
            Console.WriteLine($"Vamos Jogar Forca, você pode errar no máximo {numeroMaximoTentativas} vezes.");
            Console.WriteLine("Digite o tema da palavra-chave");
            string tema = Console.ReadLine();
            Console.WriteLine("Digite a palavra-chave para começar o jogo:");
            palavraChave = Console.ReadLine().ToLower();
            Console.Clear();

            string[] letrasCorretas = new string[palavraChave.Length];

            do
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"O tema da palavra-chave é {tema}");
                Console.WriteLine($"A palavra-chave contém {palavraChave.Length} letras");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("informe uma letra");
                string letra = Console.ReadLine().ToLower();

                if(!Regex.IsMatch(letra, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Entrada Inválida");
                    continue;
                }

                if (palavraChave.ToLower().Contains(letra))
                {
                    for (int i = 0; i < palavraChave.Length; i++)
                    {
                        if (letrasCorretas[i] == "")
                        {
                            letrasCorretas[i] = "_";
                        }
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
                        Console.WriteLine("|ˉˉˉˉ|");
                        Console.WriteLine("|    O");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        break;
                    case 2:
                        Console.WriteLine("|ˉˉˉˉ|");
                        Console.WriteLine("|    O");
                        Console.WriteLine("|    |");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        break;
                    case 3:
                        Console.WriteLine("|ˉˉˉˉ|");
                        Console.WriteLine("|    O");
                        Console.WriteLine("|   /|");
                        Console.WriteLine("|    ");
                        Console.WriteLine("|");
                        break;
                    case 4:
                        Console.WriteLine("|ˉˉˉˉ|");
                        Console.WriteLine("|    O");
                        Console.WriteLine("|   /|\\");
                        Console.WriteLine("|");
                        Console.WriteLine("|");
                        break;
                    case 5:
                        Console.WriteLine("|ˉˉˉˉ|");
                        Console.WriteLine("|    O");
                        Console.WriteLine("|   /|\\");
                        Console.WriteLine("|    |");
                        Console.WriteLine("|   / ");
                        break;
                    case 6:
                        Console.WriteLine("|ˉˉˉˉ|");
                        Console.WriteLine("|    O");
                        Console.WriteLine("|   /|\\");
                        Console.WriteLine("|    |");
                        Console.WriteLine("|   / \\");
                        Console.WriteLine("");
                        Console.WriteLine("Você foi enforcado, boa sorte na proxima vez");
                        break;
                    default:
                        Console.WriteLine("|ˉˉˉˉ|");
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