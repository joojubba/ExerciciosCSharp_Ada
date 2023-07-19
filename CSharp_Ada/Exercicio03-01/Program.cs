/*Um número inteiro positivo é dito triangular se este for o resultado do produto de três números naturais consecutivos. Por exemplo, o número 120 é triangular, dado que 120 = 4∗5∗6.
Escreva um programa que faça a leitura de um número inteiro e verifique se o número é ou não triangular. Se o número for triangular, o programa deve apresentar a mensagem 
“O número “{número}” é triangular”. Caso contrário, a mensagem deve ser “O número “{número}” NÃO é triangular”.
 * */
namespace Exercicio03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1");

            Console.WriteLine("Digite um número inteiro:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Digite o número corretamente: ");
            }

            int i = 1;
            while (i * (i + 1) * (i + 2) < n)
            {
                i += 1;

            }

            if (i * (i + 1) * (i + 2) == n)
            {
                Console.WriteLine($"O número “{n}” é triangular”.");
            }
            else
            {
                Console.WriteLine($"O número “{n}” NÃO é triangular”.");
            }
        }
    }
}