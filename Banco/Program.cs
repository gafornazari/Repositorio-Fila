using Banco;

Fila filaNormal = new Fila();
Fila filaPrioritaria = new Fila();

filaNormal.CriarFila();
filaPrioritaria.CriarFila();

int op = 1;
int contador = 0;

void MostrandoFilas()
{
    Console.WriteLine($"\nFila Prioritária atual:");
    filaPrioritaria.MostrarFila();
    Console.WriteLine($"\nFila Normal atual:");
    filaNormal.MostrarFila();
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
            Cliente cliente = new Cliente();
            Console.Write("Nome do cliente: ");
            cliente.Nome = Console.ReadLine();
            Console.Write("Idade do cliente: ");
            cliente.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("É prioritário?\n1 - Sim\n0 - Não");
            int prioridade = int.Parse(Console.ReadLine());
            if (prioridade == 1)
                filaPrioritaria.Enfileirar(cliente);
            else
                filaNormal.Enfileirar(cliente);
            MostrandoFilas();
            break;
        case 2:
            if (filaPrioritaria.Vazia() && filaNormal.Vazia())
                Console.WriteLine("Não há clientes para atender.");
            else
            {
                if (filaPrioritaria.Vazia())
                    filaNormal.Desenfileirar();

                else if (filaNormal.Vazia())
                    filaPrioritaria.Desenfileirar();

                else
                {
                    if (contador % 3 == 0)
                    {
                        filaPrioritaria.Desenfileirar();
                        contador++;
                    }
                    else
                    {
                        filaNormal.Desenfileirar();
                        contador++;
                    }
                }
                
            }
            MostrandoFilas();
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