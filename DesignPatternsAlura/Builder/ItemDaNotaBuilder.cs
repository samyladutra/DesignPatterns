using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.Builder
{
    public class ItemDaNotaBuilder
    {
        public string Descricao { get; private set; }
        public double Valor { get; private set; }
        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Descricao, Valor);
        }

        public ItemDaNotaBuilder TemNome(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        public ItemDaNotaBuilder TemValor(double valor)
        {
            Valor = valor;
            return this;
        }
    }
}
