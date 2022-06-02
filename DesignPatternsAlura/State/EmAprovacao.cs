using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.State;

public class EmAprovacao : IEstadoDeUmOrcamento
{
    private bool DescontoAplicado = false;
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        if (!DescontoAplicado)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
            DescontoAplicado = true;
        }
        else
            throw new Exception("Desconto já aplicado!");
    }

    public void Aprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Aprovado();
    }

    public void Finaliza(Orcamento orcamento)
    {
        throw new Exception("Orcamento em aprovação não podem ir para finalizado diretamente");
    }

    public void Reprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Reprovado();
    }
}
