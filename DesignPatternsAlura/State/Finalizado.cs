using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.State
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) { }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado, não é possível aprovar!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado, não é possível finalizar novamente!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado, não é possível reprovar mais!");
        }
    }
}
