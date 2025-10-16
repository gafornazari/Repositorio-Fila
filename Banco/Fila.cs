using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Fila
    {
        Cliente head;
        Cliente tail;


        public void CriarFila()
        {
            Cliente head = null;
            Cliente tail = head;
        }

        public bool Vazia()
        {
            return head == null;
        }

        public void Enfileirar(Cliente pessoa)
        {
            if (Vazia())
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

            Console.WriteLine($"Cliente {pessoa.Nome} inserido na fila!");
        }

        public void Desenfileirar()
        {
            string nomeaux = head.Nome;
            if (Vazia())
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
            Console.WriteLine($"Cliente {nomeaux} favor dirija-se ao caixa!");
        }

        public int TamanhoFila()
        {
            Cliente aux = head;
            int cont = 0;

            while (aux != null)
            {
                cont++;
                aux = aux.Proximo;
            }

            return cont;
        }

        public void MostrarFila()
        {
            if (Vazia())
            {
                Console.WriteLine("A fila está vazia!");
                return;
            }
            else
            {
                Cliente aux = head;
                while (aux != null)
                {
                    Console.WriteLine(aux.Nome);
                    aux = aux.Proximo;
                }
            }
        }
    }
}

