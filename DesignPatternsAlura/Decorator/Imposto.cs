namespace DesignPatternsAlura.Decorator;

public abstract class Imposto
{
    public Imposto? OutroImposto { get; set; }
    public Imposto(Imposto outroImposto)
    {
        OutroImposto = outroImposto;
    }
    public Imposto() { this.OutroImposto = null; }
    public abstract double CalculaImposto(Orcamento orcamento);

    protected double CalculaOutroImposto(Orcamento orcamento)
    {
        if (OutroImposto == null) return 0;
        return OutroImposto.CalculaImposto(orcamento);
    }
}
