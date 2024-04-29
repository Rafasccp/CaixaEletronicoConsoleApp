using CaixaEletronicoConsoleApp;

List<CCorrente> ccorrentes = new List<CCorrente>();
int op;
int op2;
int op3;
string? s;
do
{
    Console.WriteLine("==Menu==");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Acesso Administrativo");
    Console.WriteLine("2 - Caixa Eletronico");
    Console.WriteLine("Opcao: ");
    s = Console.ReadLine();
    int.TryParse(s, out op );

    if (op == 1)
    {
        do
        {
            Console.WriteLine("\n\nMenu 2");
            Console.WriteLine("0 - Voltar");
            Console.WriteLine("1 - Cadastro da conta corrente");
            Console.WriteLine("2 - Excluir conta corrente");
            Console.WriteLine("Opcao: ");
            s = Console.ReadLine();
            int.TryParse(s, out op2 );

            if (op2 == 1)
            {

            }
            if (op2 == 2)
            {

            }
        }while(op2 != 0);
    }
    if (op == 2)
    {
        Console.WriteLine("Qual conta voce deseja acessar?");

        do
        {
            Console.WriteLine("\n\nMenu 3");
            Console.WriteLine("0 - Voltar");
            Console.WriteLine("1 - Saque");
            Console.WriteLine("2 - Deposito");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("Opcao: ");
            s = Console.ReadLine();
            int.TryParse(s, out op3);

            if (op3 == 1)
            {

            }
            if (op3 == 2)
            {

            }
            if (op3 == 3)
            {

            }
        }while(op3 != 0);
        
    }

} while (op != 0);