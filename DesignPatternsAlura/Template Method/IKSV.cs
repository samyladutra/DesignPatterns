﻿namespace DesignPatternsAlura.Template_Method;

public class IKSV : TemplateDeImpostoCondicional
{
    public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor >= 500 && TemItemMaiorQue100ReaisNo(orcamento);
    }

    protected override double MaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1;
    }

    protected override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }

    private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
    {
        foreach (Item item in orcamento.Itens)
            if (item.Valor > 100) return true;

        return false;
    }
}
