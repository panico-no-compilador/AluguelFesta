using AluguelFesta.Dominio.ModuloTema;

namespace AluguelFesta.Infra.Dados.Arquivo.ModuloTema
{
    public class RepositorioTemaArquivo : RepositorioArquivoBase<Tema>, IRepositorioTema
    {
        public RepositorioTemaArquivo(ContextoDados contexto) : base(contexto)
        {
        }
        protected override List<Tema> ObterRegistros()
        {
            return contextoDados.temas;
        }
    }
}
