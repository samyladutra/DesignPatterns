// See https://aka.ms/new-console-template for more information


using _CR = DesignPatternsAlura.ChainResponsability;
using DesignPatternsAlura.Strategy;
using _D = DesignPatternsAlura.Decorator;
using _Filtro = DesignPatternsAlura.Decorator.FiltroContas;
using DesignPatternsAlura.Builder;
using _O = DesignPatternsAlura.Observer;
using DesignPatternsAlura.Adapter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a operação");
        Console.WriteLine("1 - Strategy");
        Console.WriteLine("2 - Chain Of Responsability");
        Console.WriteLine("3 - Template Method");
        Console.WriteLine("4 - Decorator - Imposto");
        Console.WriteLine("5 - Decorator - Filtros");
        Console.WriteLine("6 - Buider");
        Console.WriteLine("7 - Observer");

        var opcao = Console.ReadKey();

        switch (opcao.KeyChar)
        {
            case '1':
                IImposto iss = new ISS();
                IImposto icms = new ICMS();
                var orcamento = new Orcamento(500);

                var calculador = new CalculadorDeImposto();
                calculador.RealizaCalculo(orcamento, iss);
                calculador.RealizaCalculo(orcamento, icms);
                break;
            case '2':
                var calculadorDesconto = new _CR.CalculadorDeDescontos();
                var oracamentoDesconto = new _CR.Orcamento(500);
                oracamentoDesconto.AdicionarItem(new _CR.Item("CANETA", 250.0));
                oracamentoDesconto.AdicionarItem(new _CR.Item("LAPIS", 250.0));

                double desconto = calculadorDesconto.Calcula(oracamentoDesconto);

                Console.WriteLine(desconto);

                break;

            case '4':
                var impostos = new _D.ISS(new _D.ICMS());
                var orcamento_d = new _D.Orcamento(500);

                var impostoMuitoAlto = new _D.ImpostoMuitoAlto(new _D.ICMS());

                var impostoICPP_IKCV = new _D.ICPP(new _D.IKSV());
                double valor = impostos.CalculaImposto(orcamento_d);
                double valorMuitoAlto = impostoMuitoAlto.CalculaImposto(orcamento_d);
                double valorICPP_IKCV = impostoICPP_IKCV.CalculaImposto(orcamento_d);

                Console.WriteLine(valor);
                Console.WriteLine(valorMuitoAlto);
                Console.WriteLine(valorICPP_IKCV);
                break;
            case '5':
                var filtros = new _Filtro.FiltroSaldoMaior500(new _Filtro.FiltroSaldoMenor100());
                var conta1 = new _Filtro.Conta(5000500, DateTime.Now);
                var conta2 = new _Filtro.Conta(99, DateTime.MinValue);
                var conta3 = new _Filtro.Conta(80, DateTime.MaxValue);
                var contas = new List<_Filtro.Conta>();
                contas.Add(conta1);
                contas.Add(conta2);
                contas.Add(conta3);

                var contasFiltradas = filtros.Filtra(contas);
                Console.WriteLine("\n Quantidade de contas resultantes: " + contasFiltradas.Count);
                foreach (var conta in contasFiltradas)
                    Console.WriteLine(conta.Saldo);

                break;
            case '6':

                var criador = new NotaFiscalBuilder();
                criador.ParaEmpresa("Lambda3")
                    .ComCnpj("12.378.423/0001-90")
                    .Com(new ItemDaNota("item 1", 100))
                    .Com(new ItemDaNota("item 2", 200))
                    .ComObservacoes("exemplo de observação");

                NotaFiscal nf = criador.Constroi();
                Console.WriteLine(nf.ValorBruto);
                Console.WriteLine(nf.Impostos);

                break;
            case '7':
                var listaAcoes = new List<_O.IAcaoAposGerarNota>();
                listaAcoes.Add(new _O.EnviadorDeEmail());
                listaAcoes.Add(new _O.NotaFiscalDao());
                listaAcoes.Add(new _O.EnviadorDeSms());
                listaAcoes.Add(new _O.Impressora());
                var builder = new _O.NotaFiscalBuilder(listaAcoes);

                var notaFiscal = builder.ParaEmpresa("Lambda3")
                    .ComCnpj("12.378.423/0001-90")
                    .Com(new _O.ItemDaNota("item 1", 100))
                    .Com(new _O.ItemDaNota("item 2", 200))
                    .ComObservacoes("exemplo de observação")
                    .Constroi();

                Console.WriteLine(notaFiscal.ValorBruto);
                Console.WriteLine(notaFiscal.Impostos);

                break;

            case '8':
                var cliente = new Cliente();
                cliente.Nome = "Samyla";
                cliente.Endereco = "Rua Campos Sales";
                cliente.DataNascimento = DateTime.Now;

                var xml = new GeradorDeXml().GeraXml(cliente);
                Console.WriteLine(xml);
                break;
        }

        Console.ReadKey();

    }
}
