namespace DesignPatternsAlura.Observer;

public class NotaFiscalBuilder
{
    public string RazaoSocial { get; private set; }
    public string Cnpj { get; private set; }
    public string Observacoes { get; private set; }
    public DateTime Data { get; private set; }
    private double ValorTotal;
    private double Impostos;
    private IList<ItemDaNota> Itens = new List<ItemDaNota>();

    //list contendo as ações a serem executadas (para o padrão Observer):
    private IList<IAcaoAposGerarNota> TodasAcoesASeremExecutadas;

    public NotaFiscal Constroi()
    {
        var notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, Itens, Observacoes);

        foreach (var acao in TodasAcoesASeremExecutadas)
            acao.Executa(notaFiscal);

        return notaFiscal;
    }

    public NotaFiscalBuilder(List<IAcaoAposGerarNota> listaAcoes)
    {
        Data = DateTime.Now;
        TodasAcoesASeremExecutadas = listaAcoes;
    }

    public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
    {
        this.RazaoSocial = razaoSocial;
        return this;
    }

    public NotaFiscalBuilder ComCnpj(string cnpj)
    {
        this.Cnpj = cnpj;
        return this;
    }

    public NotaFiscalBuilder ComObservacoes(string observacoes)
    {
        this.Observacoes = observacoes;
        return this;
    }

    public NotaFiscalBuilder NaData(DateTime novaData)
    {
        this.Data = novaData;
        return this;
    }

    public NotaFiscalBuilder Com(ItemDaNota item)
    {
        Itens.Add(item);
        ValorTotal += item.Valor;
        Impostos += item.Valor * 0.05;
        return this;
    }
}
