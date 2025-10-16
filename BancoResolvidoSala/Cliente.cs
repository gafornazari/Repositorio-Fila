using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoResolvidoSala
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool EPrioritario { get; set; }
        public Cliente Proximo { get; set; }

        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            this.Proximo = null;
            if (idade >= 60)
            {
                EPrioritario = true;
            }
            else
            {
                EPrioritario = false;
            }
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Prioritário: " + (this.EPrioritario ? "Sim" : "Não");
        } 
    }
}
