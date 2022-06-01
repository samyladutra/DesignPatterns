namespace DesignPatternsAlura.ChainResponsability;

public class DescontoPorQuinhentosReais : IDesconto
{
    public IDesconto Proximo { get; set; }
    public double Desconta(Orcamento orcamento)
    {
        if (orcamento.Valor > 800)
            return orcamento.Valor * 0.05;

        return Proximo.Desconta(orcamento);
    }
}

