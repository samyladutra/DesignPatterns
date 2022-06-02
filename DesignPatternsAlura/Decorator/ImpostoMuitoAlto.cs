namespace DesignPatternsAlura.Decorator;

public class ImpostoMuitoAlto : Imposto
{
    public ImpostoMuitoAlto(Imposto imposto) : base(imposto) { }
    public ImpostoMuitoAlto() : base() { }
    public override double CalculaImposto(Orcamento orcamento)
    {
        return orcamento.Valor * 0.2 + CalculaOutroImposto(orcamento);
    }
}
