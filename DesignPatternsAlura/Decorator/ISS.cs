namespace DesignPatternsAlura.Decorator;

public class ISS : Imposto
{
    public ISS(Imposto outroImposto) : base(outroImposto) { }
    public ISS() : base() { }

    public override double CalculaImposto(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06 + CalculaOutroImposto(orcamento);
    }
}
