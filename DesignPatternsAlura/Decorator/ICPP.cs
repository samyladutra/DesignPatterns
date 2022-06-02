namespace DesignPatternsAlura.Decorator;

public class ICPP : Imposto
{
    public ICPP() : base() { }

    public ICPP(Imposto imposto) : base(imposto) { }
    public override double CalculaImposto(Orcamento orcamento)
    {
        return orcamento.Valor * 0.09 + CalculaOutroImposto(orcamento);
    }
}