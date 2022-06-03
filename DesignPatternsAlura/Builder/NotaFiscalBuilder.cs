using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        private double ValorTotal;
        private double Impostos;
        private IList<ItemDaNota> Itens = new List<ItemDaNota>();

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, Itens, Observacoes);
        }

        public NotaFiscalBuilder() => Data = DateTime.Now;

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime novaData)
        {
            this.Data = novaData;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            Itens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }
    }
}
