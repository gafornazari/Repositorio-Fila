using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoResolvidoSala
{
    public class Fila
    {
        public Cliente Head { get; set; }
        public Cliente Tail { get; set; }

        public Fila()
        {
            Head = null;
            Tail = null;
        }

        public bool Vazia()
        {
            return Head == null;
        }

        public void Enfileirar(Cliente cliente)
        {
            if (Vazia())
            {
                Head = cliente;
                Tail = cliente;
            }
            else
            {
                Tail.Proximo = cliente;
                Tail = cliente;
            }
            Console.WriteLine($"Cliente {cliente.Nome} inserido na fila!");
        }

        public Cliente Desenfileirar()
        {
            if (Vazia())
                return null;
            else
            {
                Cliente aux = Head;
                Head = Head.Proximo;
                if (Head == null)
                    Tail = null;
                return aux;
            }
        }

        public void MostrarFila()
        {
            if (Vazia())
            {
                Console.WriteLine("A fila está vazia!");
                return;
            }
            Cliente aux = Head;
            while (aux != null)
            {
                Console.WriteLine(aux.ToString());
                aux = aux.Proximo;
            }
        }
    }
}

