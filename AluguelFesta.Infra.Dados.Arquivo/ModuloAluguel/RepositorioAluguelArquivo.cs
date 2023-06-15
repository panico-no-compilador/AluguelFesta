using AluguelFesta.Dominio.ModuloAluguel;

namespace AluguelFesta.Infra.Dados.Arquivo.ModuloAluguel
{
    public class RepositorioAluguelArquivo : RepositorioArquivoBase<Aluguel>, IRepositorioAluguel
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
