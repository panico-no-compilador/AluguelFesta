using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.Infra.Dados.Arquivo.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelFesta.Infra.Dados.Arquivo.ModuloCliente
{
    public class RepositorioClienteArquivo : RepositorioArquivoBase<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteArquivo(ContextoDados contexto) : base(contexto)
        {

        }


        protected override List<Cliente> ObterRegistros()
        {
            return contextoDados.clientes;
        }
    }
}
