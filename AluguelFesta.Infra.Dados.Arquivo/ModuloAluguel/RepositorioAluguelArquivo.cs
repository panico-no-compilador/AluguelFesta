using AluguelFesta.Dominio.ModuloAluguel;

namespace AluguelFesta.Infra.Dados.Arquivo.ModuloAluguel
{
    internal class RepositorioAluguelArquivo : RepositorioArquivoBase<Aluguel>
    {
        public RepositorioAluguelArquivo(ContextoDados contexto) : base(contexto)
        {

        }
        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDados.alugueis;
        }
    }
}
