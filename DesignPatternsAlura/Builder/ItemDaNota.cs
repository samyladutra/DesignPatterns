using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.Builder
{
    public class ItemDaNota
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
