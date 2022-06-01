namespace DesignPatternsAlura.Strategy;

public class CalculadorDeImposto
{
    public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
    {
        double valorImposto = imposto.CalculaImposto(orcamento);
        Console.WriteLine(valorImposto.ToString());
    }
}
