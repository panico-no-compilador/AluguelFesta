using AluguelFesta.Dominio.ModuloTema;
using AluguelFesta.WinApp.Compartilhado;

namespace AluguelFesta.WinApp.ModuloTema
{
    internal class ControladorTema : ControladorBase
    {
        IRepositorioTema repositorioTema;
        TabelaTemaControl tabelaTema;
        public ControladorTema(IRepositorioTema repositorioTema)
        {
            this.repositorioTema = repositorioTema;
        }
        public override string ToolTipInserir { get { return "Inserir novo Tema"; } }
        public override string ToolTipEditar { get { return "Editar Tema existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Tema existente"; } }

        public override void Inserir()
        {
            TelaTemaForm telaTema = new TelaTemaForm();
            DialogResult opcaoEscolhida = telaTema.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema novaTema = telaTema.ObterTema();
                repositorioTema.Inserir(novaTema);
                CarregarTemas();
            }
        }
        public override void Editar()
        {
            Tema temaSelecionada = ObterTemaSelecionada();
            if (temaSelecionada == null)
            {
                MessageBox.Show(
                    "Selecione um tema primeiro",
                    "Edição de Tema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
                return;
            }
            TelaTemaForm telaTema = new TelaTemaForm();
            telaTema.ConfigurarTelaDeEdicao(temaSelecionada);
            DialogResult opcaoEscolhida = telaTema.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();
                repositorioTema.Editar(tema.Id, tema);
                CarregarTemas();
            }
        }

        public override void Excluir()
        {
            Tema temaSelecionada = ObterTemaSelecionada();
            if (temaSelecionada == null)
            {
                MessageBox.Show(
                    "Selecione um tema primeiro",
                    "Exclusão de Tema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
                return;
            }
            DialogResult opcaoEscolhida = MessageBox.Show(
                $"Deseja excluir o tema {temaSelecionada.Nome}?",
                "Exclusão de Tema",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.Excluir(temaSelecionada);
                CarregarTemas();
            }
        }
        private Tema ObterTemaSelecionada()
        {
            int id = tabelaTema.ObterIdSelecionado();
            return repositorioTema.SelecionarPorId(id);
        }
        private void CarregarTemas(List<Tema> tema)
        {
            tabelaTema.AtualizarRegistros(tema);
        }
        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
            {
                tabelaTema = new TabelaTemaControl();
            }
            CarregarTemas();
            return tabelaTema;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }
        /*
        public override void ConcluirItens()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();
            if (tarefaSelecionada == null)
            {
                MessageBox.Show(
                    "Selecione uma tarefa primeiro",
                    "Atualização de Itens da Tarefa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );

                return;
            }
            TelaConcluirItensTarefaForm telaAtualizacaoItensTarefa = new TelaConcluirItensTarefaForm(tarefaSelecionada);
            DialogResult opcaoEscolhida = telaAtualizacaoItensTarefa.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> itensMarcados = telaAtualizacaoItensTarefa.ObterItensMarcados();
                List<ItemTarefa> itensPendentes = telaAtualizacaoItensTarefa.ObterItensPendentes();
                foreach (ItemTarefa item in itensMarcados)
                {
                    tarefaSelecionada.ConcluirItem(item);
                }
                foreach (ItemTarefa item in itensPendentes)
                {
                    tarefaSelecionada.DesmarcarItem(item);
                }
                repositorioTema.Editar(tarefaSelecionada.id, tarefaSelecionada);
                CarregarTarefas();
            }
        }
         */
        /*
        public override void Adicionar()
        {
            Tema temaSelecionada = ObterTarefaSelecionada();

            if (temaSelecionada == null)
            {
                MessageBox.Show(
                    "Selecione uma tarefa primeiro",
                    "Adição de Itens da Tarefa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );

                return;
            }

            TelaItensTarefaForm telaCadastroItensTarefa = new TelaItensTarefaForm(temaSelecionada);

            DialogResult opcaoEscolhida = telaCadastroItensTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<Item> itensParaAdicionar = telaCadastroItensTarefa.ObterItensCadastrados();

                foreach (ItemTarefa item in itensParaAdicionar)
                {
                    temaSelecionada.AdicionarItem(item);
                }

                repositorioTema.Editar(temaSelecionada.Id, temaSelecionada);
                CarregarTarefas();
            }
        }
        */
        private void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();
            tabelaTema.AtualizarRegistros(temas);
        }
    }
}
