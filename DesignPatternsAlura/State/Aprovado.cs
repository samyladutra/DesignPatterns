using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.State
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        private bool DescontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!DescontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                DescontoAplicado = true;
            }
            else
                throw new Exception("Desconto já aplicado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado");
        }
    }
}
