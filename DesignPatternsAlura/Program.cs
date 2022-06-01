// See https://aka.ms/new-console-template for more information


using _CR = DesignPatternsAlura.ChainResponsability;
using DesignPatternsAlura.Strategy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a operação");
        Console.WriteLine("1 - Strategy");
        Console.WriteLine("2 - Chain Of Responsability");

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
        }



        Console.ReadKey();

    }
}
