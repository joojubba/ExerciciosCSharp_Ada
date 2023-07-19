/*Um pequeno Banco precisa de um sistema de distribuição de senhas para seus clientes. Esse sistema deve apresentar um menu com as seguintes opções:
• Emitir Senha Preferencial
• Emitir Senha Comum
• Chamar Próxima Senha
• Sair
Ao emitir as senhas, o sistema deve informar na tela a senha que foi emitida. As senhas preferenciais são formadas com a letra P seguida de uma sequência de um número sequencial 
de 3 casas. Por exemplo, a primeira senha preferencial que deve ser emitida será a P001. As senhas comuns seguem uma regra parecida, exceto pelo fato de que começam com a letra C. 
Por exemplo, a primeira senha comum a ser emitida será a C001, a seguir será a vez da senha C002 e assim por diante.
Ao selecionar a opção Chamar Próxima Senha, o sistema deverá chamar a próxima senha que deverá ser atendida. Como o nome sugere, as senhas preferenciais devem ser atendidas antes das
senhas comuns.
 * */
namespace Exercicio03_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 3\n## Menu - Banco ##\n");

            List<string> preferencial = new List<string>();
            List<string> comum = new List<string>();
            int p = 1;
            int c = 1;

            int op;

            do
            {
                Console.WriteLine("Digite:");
                Console.WriteLine("1 - Para Emitir Senha Preferencial");
                Console.WriteLine("2 - Para Emitir Senha Comum");
                Console.WriteLine("3 - Para Chamar Próxima Senha");
                Console.WriteLine("0 - Para Sair");

                while (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Digite um número do menu: ");
                }

                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        preferencial.Add($"P{p:000}");
                        Console.WriteLine($"Preferencial: Senha emitida P{p:000}");
                        p++;
                        break;
                    case 2:
                        comum.Add($"C{c:000}");
                        Console.WriteLine($"Comum: Senha emitida C{c:000}");
                        c++;
                        break;
                    case 3:
                        if (preferencial.Count > 0)
                        {
                            Console.WriteLine($"Próxima senha: {preferencial[0]}");

                            preferencial.RemoveAt(0);
                        }
                        else if (comum.Count > 0)
                        {
                            Console.WriteLine($"Próxima senha para atendimento: {comum[0]}");
                            comum.RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("Todas as senhas já foram chamadas!");
                        }
                        break;
                    default:
                        Console.WriteLine("Inválido! Digite Novamente.");
                        break;
                }

            } while (op != 0);

        }
    }
}