/*Escreva um programa que faça a leitura de uma frase, que pode ser uma citação, um ditado ou um excerto de um texto. Ao final, escreva a frase digitada e, em uma nova linha, 
 * o número de caracteres desta frase.
 * */
namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Escreva uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine($"A frase '{frase}' ");
            Console.WriteLine($"tem {frase.Length} caracteres");
        }
    }
}