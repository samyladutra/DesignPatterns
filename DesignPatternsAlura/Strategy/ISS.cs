namespace DesignPatternsAlura.Strategy;

public class ISS : IImposto
{
    public double CalculaImposto(Orcamento orcamento)
    {
        return orcamento.Valor * 0.5;
    }
}
