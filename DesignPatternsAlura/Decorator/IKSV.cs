namespace DesignPatternsAlura.Decorator;

public class IKSV : Imposto
{
    public IKSV() : base() { }
    public IKSV(Imposto imposto) : base(imposto) { }
    public override double CalculaImposto(Orcamento orcamento)
    {
        return orcamento.Valor * 0.05 + CalculaOutroImposto(orcamento);
    }
}
