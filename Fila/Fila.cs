using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEx
{
    public class Fila
    {
        Pessoa head;
        Pessoa tail;


        public void CriarFila()
        {
            Pessoa head = null;
            Pessoa tail = head;
        }

        public bool FilaVazia()
        {
            return head == null;
        }

        public void InserirPessoa(Pessoa pessoa)
        {
            if (FilaVazia())
            {
                head = pessoa;
                tail = pessoa;
                pessoa.Proximo = null;
            }
            else
            {
                tail.Proximo = pessoa;
                tail = pessoa;
            }

            Console.WriteLine("Inserido(a)!");
        }

        public void RemoverPessoa()
        {
            if (FilaVazia())
            {
                Console.WriteLine("\nA fila está vazia, não há pessoas para remover!");
                return;
            }
            else
            {
                head = head.Proximo;
                if (head == null)
                    tail = null;
            }
            Console.WriteLine("Removido(a)!");
        }

        public int TamanhoFila()
        {
            Pessoa aux = head;
            int cont = 0;

            while (aux != null)
            {
                cont++;
                aux = aux.Proximo;
            }

            return cont;
        }

        public void ImprimirFila()
        {
            if (FilaVazia())
            {
                Console.WriteLine("\nA fila está vazia!");
                return;
            }
            else
            {
                Pessoa aux = head;
                while (aux != null)
                {
                    Console.WriteLine(aux.Nome);
                    aux = aux.Proximo;
                }
            }
        }
    }
}
