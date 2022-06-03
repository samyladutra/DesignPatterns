﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.Observer;

public class EnviadorDeSms: IAcaoAposGerarNota
{
    public void Executa(NotaFiscal notaFiscal)
    {
        Console.WriteLine("enviando por sms");
    }
}
