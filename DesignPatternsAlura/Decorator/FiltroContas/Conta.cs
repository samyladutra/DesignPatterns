namespace DesignPatternsAlura.Decorator.FiltroContas;

public class Conta
{
    public Conta(double saldo, DateTime dataAbertura)
    {
        Saldo = saldo;
        DataAbertura = dataAbertura;
    }

    public double Saldo { get; set; }
    public DateTime DataAbertura { get; set; }
}
