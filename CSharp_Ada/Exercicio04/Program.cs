/*Escreva um programa para calcular a área de um círculo. A área de um círculo é dada pela seguinte fórmula: 𝐴=𝜋𝑟2
O valor do raio r será digitado pelo usuário (assumir que serão digitados apenas valores positivos).
 * */

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 4");
            Console.WriteLine("Digite o valor do raio r: ");
            double r;
            while (!double.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("Digite o valor do raio r corretamente: ");
            }
            double pi = 3.14159;

            double a = pi * (r * r);

            Console.WriteLine($"A área do círculo é: {a}");

        }
    }
}

