namespace DesignPatternsAlura.ChainResponsability;

public interface IDesconto
{
    double Desconta(Orcamento orcamento);
    IDesconto Proximo { get; set; }
}

