namespace DesignPatternsAlura.Observer;

public class ItemDaNotaBuilder
{
    public string Descricao { get; private set; }
    public double Valor { get; private set; }
    public ItemDaNota Constroi()
    {
        return new ItemDaNota(Descricao, Valor);
    }

    public ItemDaNotaBuilder TemNome(string descricao)
    {
        Descricao = descricao;
        return this;
    }

    public ItemDaNotaBuilder TemValor(double valor)
    {
        Valor = valor;
        return this;
    }
}
