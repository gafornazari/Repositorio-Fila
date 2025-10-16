using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoResolvidoSala
{
    public class Banco
    {
        public Fila FilaNormal { get; set; }
        public Fila FilaPrioritaria { get; set; }
        public int contador { get; set; }

        public Banco()
        {
            this.FilaNormal = new Fila();
            this.FilaPrioritaria = new Fila();
            contador = 0;
        }

        public Cliente AtenderCliente()
        {
            if (FilaNormal.Vazia() && FilaPrioritaria.Vazia())
                return null;
            else
            {
                if (FilaPrioritaria.Vazia())
                    return FilaNormal.Desenfileirar();

                else if (FilaNormal.Vazia())
                    return FilaPrioritaria.Desenfileirar();

                else
                {
                    if(contador % 3 == 0)
                    {
                        contador++;
                        return FilaPrioritaria.Desenfileirar();  
                    }
                    else
                    {
                        contador++;
                        return FilaNormal.Desenfileirar();
                    }
                }
            }
        }
    }
}
