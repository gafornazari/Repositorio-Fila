using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool EPrioritario { get; set; }

        public Cliente Proximo { get; set; }

        public Cliente()
        {
            this.Proximo = null;
        }

    }
}
