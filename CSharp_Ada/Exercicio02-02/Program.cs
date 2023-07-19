/*Escreva um programa que faça a leitura de 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A
 * e B e se C e D, ambos, forem positivos e se a variável A for par, o programa deve escrever na saída padrão (“Console”) a mensagem "Valores Aceitos". 
 * Caso contrário, deve escrever "Valores Não Aceitos".
 * */
namespace Exercicio02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2");

            Console.WriteLine("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            int d = int.Parse(Console.ReadLine());

            if (b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores Aceitos");
            }
            else
            {
                Console.WriteLine("Valores Não Aceitos");
            }
        }
    }
}