using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.Decorator.FiltroContas;

public class FiltroMesmoMes : Filtro
{
    public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro) { }
    public FiltroMesmoMes() : base() { }

    public override IList<Conta> Filtra(IList<Conta> contas)
    {
        return contas.Where(c => c.DataAbertura.Month == DateTime.Now.Month && c.DataAbertura.Year == DateTime.Now.Year).ToList();
    }
}
