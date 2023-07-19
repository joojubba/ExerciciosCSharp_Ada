/*Escreva um programa que faça a leitura de 5 valores Inteiros. Em seguida, o programa deve exibir no console a informação de quantos dos valores digitados são pares, 
 * quantos dos valores digitados são ímpares, quantos deles são positivos e, por fim, quantos são negativos. Cada uma das informações deve ser escrita em uma linha diferente.
 * */
namespace Exercicio02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 3");

            int[] valores = new int[5];
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Digite um valor: ");
                valores[i] = int.Parse(Console.ReadLine());
                if (valores[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }

                if (valores[i] > 0)
                {
                    positivo++;
                }
                else
                {
                    negativo++;
                }

            }
            Console.WriteLine($"Valores pares: {par}");
            Console.WriteLine($"Valores ímpares: {impar}");
            Console.WriteLine($"Valores positivos: {positivo}");
            Console.WriteLine($"Valores negativos: {negativo}");
        }
    }
}