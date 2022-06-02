﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.Template_Method;

public class ICPP : TemplateDeImpostoCondicional
{
    public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor >= 500;
    }
    protected override double MaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.07;
    }

    protected override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.05;
    }
}