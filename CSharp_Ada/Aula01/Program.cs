/*Escreva um programa que faça a leitura do nome do usuário e imprima uma saudação no console usando o nome digitado. */
namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, seja bem vidx {nome} !");
        }
    }
}