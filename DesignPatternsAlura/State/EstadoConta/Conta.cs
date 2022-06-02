namespace DesignPatternsAlura.State.EstadoConta;

public class Conta
{
    public IEstadoDaConta? Estado { get; set; }
    public void Saca(double valor)
    {
        Estado.Saca(this, valor);
    }

    public void Deposita(double valor)
    {
        Estado.Deposita(this, valor);
    }
    public double Saldo { get; set; }
    public DateTime DataAbertura { get; set; }
}
