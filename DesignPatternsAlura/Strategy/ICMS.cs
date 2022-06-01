namespace DesignPatternsAlura.Strategy;

public class ICMS : IImposto
{
    public double CalculaImposto(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1;
    }
}
