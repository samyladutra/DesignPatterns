namespace DesignPatternsAlura.Observer;

public class Multiplicador : IAcaoAposGerarNota
{
    public double Fator { get; private set; }
    public Multiplicador(double fator)
    {
        Fator = fator;
    }

    public void Executa(NotaFiscal notaFiscal)
    {
        Console.WriteLine("Multiplicador:" + notaFiscal.ValorBruto * Fator);
    }


}
