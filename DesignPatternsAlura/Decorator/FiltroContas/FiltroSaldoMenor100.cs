using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.Decorator.FiltroContas;

public class FiltroSaldoMenor100 : Filtro
{
    public FiltroSaldoMenor100(Filtro outroFiltro) : base(outroFiltro) { }
    public FiltroSaldoMenor100() : base() { }
    public override IList<Conta> Filtra(IList<Conta> contas)
    {
        var contasFiltradas = contas.Where(c => c.Saldo < 100).ToList();

        foreach (var conta in Proximo(contas))
            contasFiltradas.Add(conta);

        return contasFiltradas;
    }
}
