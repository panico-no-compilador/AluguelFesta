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
            telaTema.Tema = temaSelecionada;
            DialogResult opcaoEscolhida = telaTema.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.Editar(temaSelecionada.Id, telaTema.ObterTema());
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
        public override void AdicionarItens()
        {
            Tema temaSelecionado = ObterTemaSelecionada();

            if (temaSelecionado == null)
            {
                MessageBox.Show(
                    "Selecione um tema primeiro",
                    "Adição de Itens do Tema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
                return;
            }
            TelaItensTemaForm telaCadastroItensTema = new TelaItensTemaForm(temaSelecionado);

            DialogResult opcaoEscolhida = telaCadastroItensTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Item itensParaAdicionar = telaCadastroItensTema.Item;
                temaSelecionado.AdicionarItem(itensParaAdicionar);
                repositorioTema.Editar(temaSelecionado.Id, temaSelecionado);
            }
            CarregarTemas();
        }
        private void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();
            tabelaTema.AtualizarRegistros(temas);
        }
    }
}
