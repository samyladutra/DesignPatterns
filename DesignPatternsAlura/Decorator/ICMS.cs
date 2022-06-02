namespace DesignPatternsAlura.Decorator;

public class ICMS : Imposto
{
    public ICMS(Imposto outroImposto) : base(outroImposto) { }
    public ICMS() : base() { }
    public override double CalculaImposto(Orcamento orcamento)
    {
        return orcamento.Valor * 0.01 + CalculaOutroImposto(orcamento);
    }
}
