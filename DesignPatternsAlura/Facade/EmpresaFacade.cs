using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAlura.Facade
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().BuscaPorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }

        public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
        {
            var cobranca = new Cobranca(fatura, tipo);
            cobranca.Emite();
            return cobranca;
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            var contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }

    public class ContatoCliente
    {
        public ContatoCliente(Cliente cliente, Cobranca cobranca) { }
        public void Dispara() { }
    }
    public class ClienteDAO
    {
        public Cliente BuscaPorCpf(string cpf)
        {
            //consulta base de dados para retornar cliente, por exemplo
            return new Cliente();
        }
    }
    public class Cobranca
    {
        public Cobranca(Fatura fatura, Tipo tipoCobranca) { }

        public void Emite() { }
    }
    public class Fatura
    {
        public Fatura(Cliente cliente, double valor) { }
    }

    public enum Tipo
    {
        Boleto = 1,
        CartaoCredito = 2
    }


}
