/*Escreva um programa que faça a leitura do nome, da idade, da altura e e do peso do usuário. Após isso, escreva cada uma das informações em uma linha no console. */

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            int idade; 
            while (!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.WriteLine("Digite sua idade corretamente: ");
            }
            Console.WriteLine("Digite sua altura:");
            double altura;
            while (!double.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine("Digite sua altura corretamente: ");
            }
            Console.WriteLine("Digite seu peso:");
            double peso;
            while (!double.TryParse(Console.ReadLine(), out peso))
            {
                Console.WriteLine("Digite seu peso corretamente: ");
            }
            Console.WriteLine($"{nome} tem {idade} anos, com {altura} cm e {peso} kg");
        }
    }
}