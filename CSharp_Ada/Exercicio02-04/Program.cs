/*Escreva um programa que faça a leitura da nota de um aluno, que pode variar de 0 a 10, com até duas casas decimais. Em seguida, o programa deve exibir o “Conceito” de 
 * aproveitamento do aluno na disciplina.
 * */
namespace Exercicio02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 4");

            Console.WriteLine("Digite a sua nota: ");
            float nota;
            while (!float.TryParse(Console.ReadLine(), out nota))
            {
                Console.WriteLine("Digite sua nota corretamente: ");
            }

            if (nota >= 0.00 && nota <= 3.99)
            {
                Console.WriteLine("Conceito - Péssimo");
            }
            else if (nota >= 4.00 && nota <= 5.99)
            {
                Console.WriteLine("Conceito - Regular");

            }
            else if (nota >= 6.00 && nota <= 7.99)
            {
                Console.WriteLine("Conceito - Bom");
            }
            else if (nota >= 8.00 && nota <= 10.00)
            {
                Console.WriteLine("Conceito - Ótimo");
            }
            else
            {
                Console.WriteLine("Nota inválida!");
            }

        }
    }
}