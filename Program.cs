//int produz mesmo efeito que o string, poém apenas para números
//introduzir o dado no programa
using System.Security.Cryptography;

Console.Clear();

Console.WriteLine("Este programa irá rolar um dado e parar em um número 'aleatório'.");

Console.WriteLine();

Console.Write("Quantas faces você deseja que tenha o dado? ");

//int32 para limitar a quantia de números suportados, dados não é grande então usa-se int32bits. Caso necessário, int64bits
int faces = Convert.ToInt32(Console.Read());

//rolagem do dado
int rolagem = RandomNumberGenerator.GetInt32(1, faces);

Console.WriteLine();

Console.WriteLine($"A rolagem do dado resultou em {rolagem}");