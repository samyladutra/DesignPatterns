﻿namespace DesignPatternsAlura.Strategy;

public class Orcamento
{

    public double Valor { get; private set; }

    public Orcamento(double valor)
    {
        Valor = valor;
    }

}