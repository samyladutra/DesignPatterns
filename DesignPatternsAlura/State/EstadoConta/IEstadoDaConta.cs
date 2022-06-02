namespace DesignPatternsAlura.State.EstadoConta;

public interface IEstadoDaConta
{
    void Saca(Conta conta, double valor);
    void Deposita(Conta conta, double valor);
}
