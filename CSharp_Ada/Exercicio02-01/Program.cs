/*Escrever um programa que faça a leitura de duas strings, converta-as para inteiro e efetue a sua soma, exibindo o resultado da operação no console com uma mensagem 
 * conforme no exemplo abaixo. Não se esqueça de adicionar tratamento de erros ao seu código.
 * */
namespace Exercicio02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1");
            try
            {
                Console.WriteLine("Digite o primeiro valor: ");
                string valor1 = Console.ReadLine();
                int valor1Int = int.Parse(valor1);

                Console.WriteLine("Digite o segundo valor: ");
                string valor2 = Console.ReadLine();
                int valor2Int = int.Parse(valor2);

                int soma = valor1Int + valor2Int;
                Console.WriteLine($"O resultado da soma de \"{valor1Int}\" com \"{valor2Int}\" é \"{soma}\"");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}