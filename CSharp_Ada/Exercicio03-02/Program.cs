/*Escreva um programa que calcule e escreva a multiplicação e a divisão inteira de dois números N1 por N2, que devem ser lidos do teclado. 
 * É importante observar que a máquina que irá executar este programa é capaz de efetuar apenas duas operações matemáticas: adição e subtração. Ou seja, você não poderá usar 
 * os operadores de multiplicação, divisão, módulo etc. bem como truncamentos.
 * */
namespace Exercicio03_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2");

            Console.WriteLine("Digite um número:");
            int n1;
            while (!int.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Digite o número corretamente: ");
            }
            Console.WriteLine("Digite outro número:");
            int n2;
            while (!int.TryParse(Console.ReadLine(), out n2))
            {
                Console.WriteLine("Digite o número corretamente: ");
            }

            int mult = 0;
            int div = 0;
            int i = 0;

            while (i < Math.Abs(n2))
            {
                mult += Math.Abs(n1);
                i++;

            }
            if ((n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0))
            {
                mult = -mult;
            }

            Console.WriteLine($" A multiplicação de {n1} * {n2} é {mult}");

            int divn1 = Math.Abs(n1);
            int divn2 = Math.Abs(n2);
            while (divn1 >= divn2)
            {
                divn1 -= divn2;
                div++;

            }
            if ((n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0))
            {
                div = -div;
            }

            Console.WriteLine($" A divisão de {n1} / {n2} é {div}");
        }
    }
}