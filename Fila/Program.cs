using FilaEx;

Fila fila = new Fila();
int op = 1;

fila.CriarFila();

do
{

    Console.WriteLine("\n\nO que você deseja fazer?");
    Console.WriteLine("1 - Inserir pessoa na fila");
    Console.WriteLine("2 - Remover pessoa da fila");
    Console.WriteLine("3 - Imprimir a fila");
    Console.WriteLine("4 - Saber o tamanho a fila");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Qual o nome da pessoa?");
            pessoa.Nome = Console.ReadLine();
            fila.InserirPessoa(pessoa);
            break;
        case 2:
            fila.RemoverPessoa();
            break;
        case 3:
            Console.WriteLine("Fila:");
            fila.ImprimirFila();
            break;
        case 4:
            Console.Write("Tamanho da fila: ");
            Console.WriteLine(fila.TamanhoFila()); 
            break;
        default:
            if (op != 0)
                Console.WriteLine("Opção inválida!");
            break;
    }

} while (op != 0);
