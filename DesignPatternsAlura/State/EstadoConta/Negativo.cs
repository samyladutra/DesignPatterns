namespace DesignPatternsAlura.State.EstadoConta;

public class Negativo : IEstadoDaConta
{
    public void Deposita(Conta conta, double valor)
    {
        conta.Saldo += valor * 0.98;
        if (conta.Saldo > 0) conta.Estado = new Positivo();
    }

    public void Saca(Conta conta, double valor)
    {
        throw new Exception("Conta já está negativada. Não é possível realizar saque!");
    }
}
