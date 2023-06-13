using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelFesta.Infra.Dados.Arquivo.Compartilhado
{
    public abstract class RepositorioArquivoBase<IEntidadeBase>
        where IEntidadeBase : EntidadeBase<IEntidadeBase>
    {
        protected ContextoDados contextoDados;
        protected int contador;

        public RepositorioArquivoBase(ContextoDados contexto)
        {
            contextoDados = contexto;
            AtualizarContador();
        }
        private void AtualizarContador()
        {
            if (ObterRegistros().Count > 0)
                contador = ObterRegistros().Max(x => x.Id);
        }
        public virtual IEntidadeBase SelecionarPorId(int id)
        {
            IEntidadeBase entidade = ObterRegistros().FirstOrDefault(x => x.Id == id);

            return entidade;
        }
        public virtual void Inserir(IEntidadeBase novaEntidade)
        {
            contador++;
            novaEntidade.Id = contador;
            ObterRegistros().Add(novaEntidade);
            contextoDados.GravarEmArquivoJson();

        }
        public virtual void Editar(int id, IEntidadeBase entidadeAtualizada)
        {
            IEntidadeBase entidadeSelecionada = SelecionarPorId(id);
            entidadeSelecionada.AtualizarInformacoes(entidadeAtualizada);
            contextoDados.GravarEmArquivoJson();
        }
        public virtual void Excluir(IEntidadeBase entidadeSelecionada)
        {
            ObterRegistros().Remove(entidadeSelecionada);
            contextoDados.GravarEmArquivoJson();
        }

        protected abstract List<IEntidadeBase> ObterRegistros();
        public virtual List<IEntidadeBase> SelecionarTodos()
        {
            return ObterRegistros();
        }
    }
}
