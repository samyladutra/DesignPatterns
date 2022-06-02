using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.Decorator.FiltroContas;

public class FiltroSaldoMaior500 : Filtro
{
    public FiltroSaldoMaior500(Filtro outroFiltro) : base(outroFiltro) { }
    public FiltroSaldoMaior500() : base() { }
    public override IList<Conta> Filtra(IList<Conta> contas)
    {
        var contasFiltradas = contas.Where(c => c.Saldo > 500000).ToList();

        foreach (var conta in Proximo(contas))
            contasFiltradas.Add(conta);

        return contasFiltradas;
    }
}
