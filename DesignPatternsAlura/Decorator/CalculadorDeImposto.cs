namespace DesignPatternsAlura.Decorator;

public class CalculadorDeImposto
{
    public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
    {
        double valorImposto = imposto.CalculaImposto(orcamento);
        Console.WriteLine(valorImposto.ToString());
    }
}
