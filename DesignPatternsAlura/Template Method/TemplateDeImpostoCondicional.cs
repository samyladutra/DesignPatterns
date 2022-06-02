namespace DesignPatternsAlura.Template_Method;

public abstract class TemplateDeImpostoCondicional : IImposto
{
    public double CalculaImposto(Orcamento orcamento)
    {
        if (DeveUsarMaximaTaxacao(orcamento))
            return MaximaTaxacao(orcamento);

        return MinimaTaxacao(orcamento);
    }

    public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    protected abstract double MaximaTaxacao(Orcamento orcamento);
    protected abstract double MinimaTaxacao(Orcamento orcamento);
}
