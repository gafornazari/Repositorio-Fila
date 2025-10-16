using BancoResolvidoSala;

Banco banco = new Banco();

int op = 1;

void MostrandoFilas()
{
    Console.WriteLine($"\nFila Prioritária atual:");
    banco.FilaPrioritaria.MostrarFila();
    Console.WriteLine($"\nFila Normal atual:");
    banco.FilaNormal.MostrarFila();
}

do
{
    Console.WriteLine("\n\nO que você deseja fazer?");
    Console.WriteLine("1 - Adicionar cliente");
    Console.WriteLine("2 - Atender próximo cliente");
    Console.WriteLine("3 - Mostrar filas");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("Informe o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a idade do cliente: ");
            int idade = int.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome, idade);
            if (cliente.EPrioritario)
                banco.FilaPrioritaria.Enfileirar(cliente);
            else
                banco.FilaNormal.Enfileirar(cliente);
            MostrandoFilas();
            break;
        case 2:
            cliente = banco.AtenderCliente();
            if(cliente == null)
                Console.WriteLine("Não há clientes para atender.");
            else
            {
                Console.WriteLine(cliente.ToString());
                MostrandoFilas();
            }
            break;
        case 3:
            MostrandoFilas();
            break;
        default:
            if (op != 0)
                Console.WriteLine("Opção inválida!");
            break;
    }




} while (op != 0);